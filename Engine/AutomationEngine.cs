using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using NPoco;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace Engine
{
    public class AutomationEngine
    {
        public delegate void ProgressEventHandler(object sender, EventArgs<int> args);
        public event ProgressEventHandler OnProgress;

        public delegate void ErrorEventHandler(object sender, EventArgs<string> args);
        public event ErrorEventHandler OnError;

        private const string EbayImageSeparator = "|";
        private const string ReviseFileHeaders = "Action(SiteID=US|Country=US|Currency=USD|Version=585|CC=ISO-8859-1),ItemID,Title,PicUrl";
        private const string FilesFolder = @"C:\rsbot-files";

        private readonly FirefoxProfile firefoxProfile;
        private readonly CsvReader csvReader;
        private readonly SettingsData settings;

        public AutomationEngine(SettingsData settings)
        {
            this.settings = settings;

            firefoxProfile = new FirefoxProfile();
            firefoxProfile.AcceptUntrustedCertificates = true;
            firefoxProfile.SetPreference("browser.download.folderList", 2);//browser dir
            firefoxProfile.SetPreference("browser.download.dir", FilesFolder);
            firefoxProfile.SetPreference("browser.helperApps.neverAsk.saveToDisk","text/csv");

            csvReader = new CsvReader();
        }

        public void UploadRevised()
        {
            settings.UploadRefId = null;

            using (var db = GetDb())
            {
                var listings = db.Query<Listing>().ToArray();

                var lines = new List<string>();
                lines.Add(ReviseFileHeaders);

                foreach (var listing in listings)
                {
                    string currentLine = $"Revise,{ listing.EbayId },{ listing.Title },{listing.PicUrl}";
                    lines.Add(currentLine);
                }

                var filename = FilesFolder + "\\" + Guid.NewGuid() + ".csv";
                File.WriteAllLines(filename, lines);

                const string url =
                    "http://bulksell.ebay.com/ws/eBayISAPI.dll?FileExchangeUploadForm&ssPageName=STRK:ME:LNLK";

                using (IWebDriver driver = GetDriver())
                {
                    driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 0, 10));

                    NavigateWithLogin(driver, url);

                    driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 0, 10));
                    driver.FindElement(By.CssSelector("input[type='file']")).SendKeys(filename);

                    driver.FindElement(By.Id("Upload")).Click();

                    driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 1, 0));

                    var refCandidates =
                        driver.FindElements(By.CssSelector("table > tbody > tr > td")).Where(item => item.Text.Contains("ref")).ToList();

                    var regex = new Regex(@"Your ref # is \d+");
                    foreach (var candidate in refCandidates)
                    {
                        var match = regex.Match(candidate.Text);
                        if (match.Success)
                        {
                            settings.UploadRefId = new Regex(@"\d+").Match(match.Value).Value;
                        }
                    }

                    driver.Close();
                }
            }
        }

        public void DownloadImages()
        {
            using (var db = GetDb())
            {
                var dbListring = db.Query<Listing>().ToArray();
                var client = new HttpClient();

                foreach (var listing in dbListring)
                {
                    string url = $"http://www.ebay.com/itm/{listing.EbayId}";

                    var requestTask = client.GetAsync(url);
                    requestTask.Wait();

                    var contentTask = requestTask.Result.Content.ReadAsStringAsync();
                    contentTask.Wait();

                    var result = contentTask.Result;

                    Regex regex = new Regex("http://i.ebayimg.com/images/g/[a-z|A-Z|0-9]*/s-l[0-9]*.jpg");
                    var matches = regex.Matches(result);

                    var imageUrls = new List<string>();
                    for (var matchIndex = 0; matchIndex < matches.Count; matchIndex++)
                    {
                        var match = matches[matchIndex];
                        
                        var fixedUrl = match.Value.Substring(0, match.Value.LastIndexOf("s-")) + "s-l1000.jpg";
                        imageUrls.Add(fixedUrl);
                    }

                    listing.PicUrl = imageUrls.Distinct().Aggregate((left,right) => left + EbayImageSeparator + right);

                    db.Save(listing);
                    Console.WriteLine(listing.PicUrl);
                }
            }
        }

        public void VerifyUploadNoErrors()
        {
            var refId = settings.UploadRefId;
            var filename = $"{FilesFolder}\\FileExchange_Response_{refId}.csv";

            var reader = new StreamReader(File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
            if (reader.EndOfStream)
            {
                return;
            }

            var headers = reader.ReadLine().Split(',').ToList();

            var indStatus = headers.IndexOf("Status");

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                var status = line.Split(',')[indStatus];

                if (status != "Success" && status != "Warning")
                {
                    return;
                }
            }
        }

        public void DownloadUploadVerification()
        {
            const string url = "http://bulksell.ebay.com/ws/eBayISAPI.dll?FileExchangeUploadResults&ssPageName=STRK:ME:LNLK";

            using (IWebDriver driver = GetDriver())
            {
                driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 0, 10));

                NavigateWithLogin(driver, url);

                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 0, 10));
                var row =
                    driver.FindElements(By.CssSelector("tr")).Where(item => item.Text.Contains(settings.UploadRefId)).ToList().Last();

                while (!row.Text.Contains("Complete"))
                {
                    driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 1, 0));
                }

                var refId = settings.UploadRefId;
                driver.Navigate().GoToUrl($"http://bulksell.ebay.com/ws/eBayISAPI.dll?FileExchangeDownload&jobId={refId}");
            }
        }

        public void PrepareDownloadListing()
        {
            settings.DownloadRefId = PrepareDownload(false);
        }

        public void PrepareDownloadUpc()
        {
            settings.DownloadUpcRefId = PrepareDownload(true);
        }

        private string PrepareDownload(bool addUpc)
        {
            const string url = "http://k2b-bulk.ebay.com/ws/eBayISAPI.dll?SMDownloadRequest&ssPageName=STRK:ME:LNLK";

            var refId = string.Empty;

            using (IWebDriver driver = GetDriver())
            {
                driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 0, 10));

                NavigateWithLogin(driver, url);

                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 0, 10));

                var listFilters = driver.FindElement(By.Id("ListingFilter"));
                new SelectElement(listFilters).SelectByText("Active");

                if (addUpc)
                {
                    driver.FindElement(By.Id("DownloadFormatType2")).Click();

                    var listAddUPC = driver.FindElement(By.Id("FEActiveDownloadType"));
                    new SelectElement(listAddUPC).SelectByValue("5");
                }

                listFilters.Submit();

                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 0, 10));

                var refCandidates =
                    driver.FindElements(By.CssSelector("table > tbody > tr > td")).Where(item => item.Text.Contains("ref")).ToList();

                var regex = new Regex(@"Your ref # is \d+");
                foreach (var candidate in refCandidates)
                {
                    var match = regex.Match(candidate.Text);
                    if (match.Success)
                    {
                        refId = new Regex(@"\d+").Match(match.Value).Value;
                    }
                }
                driver.Quit();
            }

            return refId;
        }

        public void DownloadListing()
        {
            Download(settings.DownloadRefId); 
        }

        public void DownloadUpc()
        {
            Download(settings.DownloadUpcRefId);
        }

        public void ImportListings()
        {
            var refId = settings.DownloadRefId;
            var filename = $"{FilesFolder}\\FileExchange_Response_{refId}.csv";

            var listings =
                csvReader.Read(filename).Select(line =>
                    new Listing
                    {
                        EbayId = line["Item ID"],
                        Asin = line["Custom Label"],
                        Quantity = int.Parse(line["Quantity Available"]),
                        Purchases = int.Parse(line["Purchases"]),
                        Price = double.Parse(line["Price"].Trim('$')),
                        StartDate = string.IsNullOrWhiteSpace(line["Start Date"])
                            ? (DateTime?) null
                            : DateTime.Parse(line["Start Date"]),
                        EndDate =
                            string.IsNullOrWhiteSpace(line["End Date"])
                                ? (DateTime?) null
                                : DateTime.Parse(line["End Date"]),
                        Title = line["Item Title"],
                        Category = line["Category Leaf Name"]
                    });

            using (var db = GetDb())
            {
                // There is no save bulk. Only insert bulk. We want to make sure we insert or update existing
                foreach (var listing in listings)
                {
                    db.Save(listing);
                }
            }
        }

        public void ImportUpcCodes()
        {
            var refId = settings.DownloadUpcRefId;

            var filename = $"{FilesFolder}\\FileExchange_Response_{refId}.csv";

            using (var db = GetDb())
            {
                foreach (var line in csvReader.Read(filename))
                {
                    var ebayId = line["ItemID"];
                    var upc = line["Product:UPC"];

                    if (upc != "does not apply")
                    {
                        var dbListring = db.SingleById<Listing>(ebayId);

                        dbListring.Upc = upc;
                        db.Save(dbListring);
                    }
                }
            }
        }

        public void OptimizeImages()
        {
            var account = new Account(settings.CloudinaryAppName, settings.CloudinaryKey, settings.CloudinarySecret);
            var cloudinary = new Cloudinary(account);

            Listing[] listings = null;

            using (var db = GetDb())
            {
                listings =
                    db.Query<Listing>(Sql.Builder.Where("ebay_id not in (select ebay_id from listing_trans_log)"))
                        .ToArray();
            }

            var tranformationLogs = new List<ListingTransformationLog>();

            foreach (var listing in listings)
            {
                var picUrls = listing.PicUrl.Split(EbayImageSeparator[0]);

                var uploadResults = new List<ImageUploadResult>();
                var updatedImageUrls = new List<string>();

                foreach (var image in picUrls)
                {
                    var uploadParams = new ImageUploadParams {File = new FileDescription(image)};
                    var uploadResult = cloudinary.Upload(uploadParams);

                    uploadResults.Add(uploadResult);

                    var url = cloudinary.Api.UrlImgUp.Transform(new Transformation()
                        .Flags("sanitize", "text_disallow_overflow")
                        .Height(1000)
                        .Quality("auto:eco")
                        .Width(1000)
                        .Crop("mfit")
                        .Chain()
                        .Effect("gradient_fade:20")
                        .Gravity("south_east")
                        .Height(100)
                        .Overlay(settings.CloudinaryWatermarkId)
                        .Opacity(30)
                        .Width(100)
                        .X(10)
                        .Y(10)
                        .Crop("thumb")).BuildImageTag(uploadResult.PublicId + ".jpg");

                    updatedImageUrls.Add(url.ToHtmlString());
                }

                var addCollage = uploadResults.Count > 1;

                if (addCollage)
                {
                    var collageCandidates =
                        uploadResults.Where(item => item.Faces != null && item.Faces.Length >= 1)
                            .Concat(uploadResults.Where(item => item.Faces == null)).Take(2).ToList();

                    var collageUrl = cloudinary.Api.UrlImgUp.Transform(new Transformation()
                        .Width(500).Height(1000).Crop("fill").Chain()
                        .Overlay(collageCandidates[1].PublicId)
                        .Width(500).Height(1000).X(250).Crop("fill").Quality("auto:eco").Chain()
                        .Effect("gradient_fade:20").Gravity("south_east")
                        .Height(100).Width(100)
                        .X(10).Y(10)
                        .Overlay(settings.CloudinaryWatermarkId)
                        .Opacity(30)
                        .Crop("thumb")).BuildImageTag(collageCandidates[0].PublicId + ".jpg");

                    updatedImageUrls.Insert(0, collageUrl.ToHtmlString());
                }

                tranformationLogs.Add(new ListingTransformationLog
                {
                    Timestamp = DateTime.UtcNow,
                    EbayId = listing.EbayId,
                    CollageAdded = addCollage
                });

                listing.PicUrl =
                    updatedImageUrls.Distinct().Aggregate((left, right) => left + EbayImageSeparator + right);
            }

            using (var db = GetDb())
            {
                db.InsertBatch(tranformationLogs, new BatchOptions {BatchSize = 100});

                foreach (var listing in listings)
                {
                    db.Save(listing);
                }
            }
        }

        private void Download(string refId)
        {
            const string url = "http://k2b-bulk.ebay.com/ws/eBayISAPI.dll?SMDownloadPickup&ssPageName=STRK:ME:LNLK";

            using (IWebDriver driver = GetDriver())
            {
                driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 0, 10));
                NavigateWithLogin(driver, url);

                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 0, 10));
                var row =
                    driver.FindElements(By.CssSelector("tr")).Where(item => item.Text.Contains(refId)).ToList().Last();

                while (!row.Text.Contains("File Complete"))
                {
                    driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 1, 0));
                }

                driver.Navigate().GoToUrl($"http://bulksell.ebay.com/ws/eBayISAPI.dll?FileExchangeDownload&RefId={refId}");

                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 1, 0));

                driver.Close();
            }
        }

        private void NavigateWithLogin(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);

            var usernameElement =
                driver.FindElements(By.CssSelector("input[placeholder='Email or username']"))
                    .Single(element => element.Displayed);
            usernameElement.SendKeys(settings.EbayUser);

            var passwordElement = driver.FindElement(By.CssSelector("input[type='password']"));
            passwordElement.SendKeys(settings.EbayPassword);
            passwordElement.Submit();
        }

        private Database GetDb()
        {
            return new Database(settings.Database, DatabaseType.MySQL);
        }

        private IWebDriver GetDriver()
        {
            return new FirefoxDriver(firefoxProfile);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using NPoco;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Engine.Amazon;
using Engine.Models;
using NPoco.Linq;

namespace Engine
{
    public class AutomationEngine
    {
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

        public void PrepareRevisedFile(IActionController controller)
        {
            settings.UploadRefId = null;

            using (var db = GetDb())
            {
                var listings = db.Query<Listing>().ToArray();

                var lines = new List<string> { ReviseFileHeaders };

                foreach (var listing in listings)
                {
                    var title = listing.Title.Replace("\"", "\"\"");
                    var picUrl = listing.PicUrl.Replace("\"", "\"\"");

                    string currentLine = $"Revise,{listing.EbayId},\"{title}\",\"{picUrl}\"";
                    lines.Add(currentLine);
                }

                var filename = FilesFolder + "\\" + Guid.NewGuid() + ".csv";
                File.WriteAllLines(filename, lines);

                settings.RevisedFileToUpload = filename;
            }
        }

        public void UploadRevised(IActionController controller)
        {
            const string url =
                "http://bulksell.ebay.com/ws/eBayISAPI.dll?FileExchangeUploadForm&ssPageName=STRK:ME:LNLK";

            using (IWebDriver driver = GetDriver())
            {
                driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 0, 10));

                NavigateWithLogin(driver, url);

                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 0, 10));
                driver.FindElement(By.CssSelector("input[type='file']")).SendKeys(settings.RevisedFileToUpload);

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

        public void DownloadImages(IActionController controller)
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

        public void VerifyUploadNoErrors(IActionController controller)
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

        public void DownloadUploadVerification(IActionController controller)
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

                Thread.Sleep(30 * 1000);

                driver.Close();
            }
        }

        public void PrepareDownloadListing(IActionController controller)
        {
            settings.DownloadRefId = PrepareDownload(false);
        }

        public void PrepareDownloadUpc(IActionController controller)
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

                driver.Close();
            }

            return refId;
        }

        public void DownloadListing(IActionController controller)
        {
            Download(settings.DownloadRefId); 
        }

        public void DownloadUpc(IActionController controller)
        {
            Download(settings.DownloadUpcRefId);
        }

        public void ImportListings(IActionController controller)
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
                db.DeleteMany<Listing>().Where(listing => true).Execute();
                db.InsertBulk(listings);
            }
        }

        public void ImportUpcs(IActionController controller)
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

        public void OptimizeImages(IActionController controller)
        {
            Listing[] listings;

            using (var db = GetDb())
            {
                IQueryProvider<Listing> query = db.Query<Listing>();
                
                if (settings.AmazonOptimizeImagesOnlyForNewProducts)
                {
                    query = query.Where("ebay_id not in (select ebay_id from listing_trans_log)");
                }

                listings = query.ToArray();
            }

            var tranformationLogs = new List<ListingTransformationLog>();

            var cloudinaryAccount = new Account(settings.CloudinaryAppName, settings.CloudinaryKey, settings.CloudinarySecret);
            var cloudinary = new Cloudinary(cloudinaryAccount);

            foreach (var listing in listings)
            {
                var picUrls = GetAmazonImages(listing.Asin, controller);

                if (picUrls == null)
                {
                    controller.ReportWarning("Cannot get images from Amazon to product " + listing.Asin);
                    continue;
                }

                var uploadResults = new List<ImageUploadResult>();
                var updatedImageUrls = new List<string>();

                foreach (var uploadResult in picUrls.Select(image => new ImageUploadParams {File = new FileDescription(image)}).Select(uploadParams => cloudinary.Upload(uploadParams)))
                {
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
                        .Width(225)
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

                    // Make 1000x1000 with white padding, no scaling
                    var transformation = new Transformation()
                            .Width(1000).Height(1000).Crop("pad").Chain()
                            .Width(1000).Height(1000).Crop("fill").Chain();

                    // Add the 2nd item to the collage, to the top left corner
                    transformation = transformation
                        .Overlay(collageCandidates[1].PublicId)
                        .Width(240).Height(240).X(-250).Y(-250).Crop("fill").Quality("auto:eco").Chain();

                    // Add watermark
                    transformation = transformation
                        .Effect("gradient_fade:20").Gravity("south_east").Height(100).Width(225).X(10).Y(10)
                        .Overlay(settings.CloudinaryWatermarkId).Opacity(30).Crop("thumb");

                    // Get the final URL
                    var collageUrl = cloudinary.Api.UrlImgUp
                        .Transform(transformation)
                        .BuildImageTag(collageCandidates[0].PublicId + ".jpg");

                    updatedImageUrls.Insert(0, collageUrl.ToString());
                }

                tranformationLogs.Add(new ListingTransformationLog
                {
                    Timestamp = DateTime.UtcNow,
                    EbayId = listing.EbayId,
                    CollageAdded = addCollage
                });

                var nakedUrls = updatedImageUrls
                    .Select(item =>
                    {
                        var start = item.IndexOf("\"", StringComparison.Ordinal);
                        var end = item.LastIndexOf("\"", StringComparison.Ordinal);
                        return item.Substring(start, end - start).Trim('"');
                    })
                    .ToList();

                listing.PicUrl = string.Format("\"{0}\"",
                    nakedUrls.Distinct().Aggregate((left, right) => left + EbayImageSeparator + right));
            }

            using (var db = GetDb())
            {
                foreach (var tranformationLog in tranformationLogs)
                {
                    db.Save(tranformationLog);
                }

                foreach (var listing in listings)
                {
                    db.Save(listing);
                }
            }
        }

        public void WaitForDownloadFile(IActionController controller)
        {
            Thread.Sleep(settings.WaitForDownloadSeconds * 1000);
        }

        public void WaitForUploadFile(IActionController controller)
        {
            Thread.Sleep(settings.WaitForUploadSeconds * 1000);
        }

        public void OptimizeTitles(IActionController controller)
        {
            var loader = new CompetiveItemsLoader(settings, controller);

            Listing[] listings = null;
            using (var db = GetDb())
            {
                listings = db.Query<Listing>().ToArray();
            }

            foreach (var listing in listings.Where(item => !string.IsNullOrEmpty(item.Upc)))
            {
                IEnumerable<CompetativeItem> competativeItems = loader.GetCompetativeItems(listing.EbayId, listing.Upc);

                using (var db = GetDb())
                {
                    db.BeginTransaction();

                    var itemIds = new {ids = competativeItems.Select(item => item.EbayId)};
                    db.Delete<CompetativeItem>(Sql.Builder.Where("ebay_id in (@ids)", itemIds));
                    db.InsertBulk(competativeItems);

                    db.CompleteTransaction();
                }

                foreach (var item in competativeItems)
                {
                    using (var db = GetDb())
                    {
                        db.BeginTransaction();

                        var transIds = new {ids = item.Transactions.Select(trans => trans.TransactionId)};
                        db.Delete<CompetativeItemTransaction>(Sql.Builder.Where("transaction_id in (@ids)",
                            transIds));
                        db.InsertBulk(item.Transactions);

                        db.CompleteTransaction();
                    }
                }
            }
        }

        private IEnumerable<string> GetAmazonImages(string asin, IActionController controller)
        {
            ItemLookupResponse result = null;
            var retryCount = 0;

            while (result == null)
            {
                try
                {
                    var lookup = new ItemLookup
                    {
                        AssociateTag = settings.AmazonAssociateId,
                        AWSAccessKeyId = settings.AmazonKeyId
                    };

                    var request = new ItemLookupRequest
                    {
                        ItemId = new[] { asin },
                        IdType = ItemLookupRequestIdType.ASIN,
                        ResponseGroup = new[] { "Images" }
                    };

                    lookup.Request = new[] { request };

                    AWSECommerceServicePortTypeClient amzwc = new AWSECommerceServicePortTypeClient();
                    amzwc.ChannelFactory.Endpoint.EndpointBehaviors.Add(new AmazonSigningEndpointBehavior(settings.AmazonKeyId, settings.AmazonKeySecret));

                    result = amzwc.ItemLookup(lookup);
                }
                catch
                {
                    retryCount++;
                    if (retryCount == 3)
                    {
                        return null;
                    }

                    var sleepTime = 30 * retryCount;
                    controller.ReportWarning($"Amazon request failed for asin { asin }. Will retry in { sleepTime } seconds");
                    Thread.Sleep(sleepTime * 1000);
                }
            }

            var item = result.Items[0]?.Item?[0];

            var mainImageUrl = item?.LargeImage?.URL;

            if (mainImageUrl == null)
            {
                mainImageUrl = item?.ImageSets?.First().LargeImage?.URL;
            }

            if (item == null || result.OperationRequest.Errors != null || item.Errors != null || string.IsNullOrWhiteSpace(mainImageUrl))
            {
                return null;
            }

            var otherUrls = item.ImageSets.Select(image => image.LargeImage.URL).Where(url => url != mainImageUrl).Distinct().ToArray();

            return new[] {mainImageUrl}.Concat(otherUrls).ToArray().Where(url => url != null).Distinct();
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
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using NPoco;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Engine
{
    public class AutomationEngine
    {
        const string ReviseFileHeaders = "Action(SiteID=US|Country=US|Currency=USD|Version=585|CC=ISO-8859-1),ItemID,Title,PicUrl";
        private const string FilesFolder = @"C:\rsbot-files";

        private readonly FirefoxProfile firefoxProfile;
        private readonly CsvReader csvReader;

        public AutomationEngine()
        {
            firefoxProfile = new FirefoxProfile();
            firefoxProfile.AcceptUntrustedCertificates = true;
            firefoxProfile.SetPreference("browser.download.folderList", 2);//browser dir
            firefoxProfile.SetPreference("browser.download.dir", FilesFolder);
            firefoxProfile.SetPreference("browser.helperApps.neverAsk.saveToDisk","text/csv");

            csvReader = new CsvReader();
        }

        public string UploadRevised(string connectionString, string username, string password)
        {
            string refId = null;

            using (var db = GetDb(connectionString))
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

                    NavigateWithLogin(username, password, driver, url);

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
                            refId = new Regex(@"\d+").Match(match.Value).Value;
                        }
                    }


                    driver.Close();
                }
            }
            return refId;
        }

        public bool VerifyUploadNoErrors(string uploadRefId)
        {
            var filename = $"{FilesFolder}\\FileExchange_Response_{uploadRefId}.csv";

            var reader = new StreamReader(File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
            if (reader.EndOfStream)
            {
                return false;
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
                    return false;
                }
            }

            return true;
        }

        public void DownloadUploadVerification(string username, string password, string refId)
        {
            const string url = "http://bulksell.ebay.com/ws/eBayISAPI.dll?FileExchangeUploadResults&ssPageName=STRK:ME:LNLK";

            using (IWebDriver driver = GetDriver())
            {
                driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 0, 10));

                NavigateWithLogin(username, password, driver, url);

                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 0, 10));
                var row =
                    driver.FindElements(By.CssSelector("tr")).Where(item => item.Text.Contains(refId)).ToList().Last();

                while (!row.Text.Contains("Complete"))
                {
                    driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 1, 0));
                }

                driver.Navigate().GoToUrl($"http://bulksell.ebay.com/ws/eBayISAPI.dll?FileExchangeDownload&jobId={refId}");
            }
        }

        public string PrepareDownload(string username, string password, bool addUpc = false)
        {
            const string url = "http://k2b-bulk.ebay.com/ws/eBayISAPI.dll?SMDownloadRequest&ssPageName=STRK:ME:LNLK";

            var refId = string.Empty;

            using (IWebDriver driver = GetDriver())
            {
                driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 0, 10));

                NavigateWithLogin(username, password, driver, url);

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

        public void Download(string username, string password, string refId)
        {
            const string url = "http://k2b-bulk.ebay.com/ws/eBayISAPI.dll?SMDownloadPickup&ssPageName=STRK:ME:LNLK";

            using (IWebDriver driver = GetDriver())
            {
                driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 0, 10));
                NavigateWithLogin(username, password, driver, url);

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

        public void ImportListings(string refId, string connectionString)
        {
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

            using (var db = GetDb(connectionString))
            {
                // There is no save bulk. Only insert bulk. We want to make sure we insert or update existing
                foreach (var listing in listings)
                {
                    db.Save(listing);
                }
            }
        }

        public void ImportUpcCodes(string refId, string connectionString)
        {
            var filename = $"{FilesFolder}\\FileExchange_Response_{refId}.csv";

            using (var db = GetDb(connectionString))
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

        private static void NavigateWithLogin(string username, string password, IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);

            var usernameElement =
                driver.FindElements(By.CssSelector("input[placeholder='Email or username']"))
                    .Single(element => element.Displayed);
            usernameElement.SendKeys(username);

            var passwordElement = driver.FindElement(By.CssSelector("input[type='password']"));
            passwordElement.SendKeys(password);
            passwordElement.Submit();
        }

        private Database GetDb(string connectionString)
        {
            return new Database(connectionString, DatabaseType.MySQL);
        }

        private IWebDriver GetDriver()
        {
            return new FirefoxDriver(firefoxProfile);
        }
    }
}

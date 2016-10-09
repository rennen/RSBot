using System;
using System.Collections.Generic;
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

        public AutomationEngine()
        {
            firefoxProfile = new FirefoxProfile();
            firefoxProfile.AcceptUntrustedCertificates = true;
            firefoxProfile.SetPreference("browser.download.folderList", 2);//browser dir
            firefoxProfile.SetPreference("browser.download.dir", FilesFolder);
            firefoxProfile.SetPreference("browser.helperApps.neverAsk.saveToDisk","text/csv");
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

        public bool VerifyNoErrors(string uploadRefId)
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

        public string PrepareDownload(string username, string password)
        {
            const string url = "http://k2b-bulk.ebay.com/ws/eBayISAPI.dll?SMDownloadRequest&ssPageName=STRK:ME:LNLK";

            var refId = string.Empty;

            using (IWebDriver driver = GetDriver())
            {
                driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 0, 10));

                NavigateWithLogin(username, password, driver, url);

                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 0, 10));

                var list = driver.FindElement(By.Id("ListingFilter"));
                new SelectElement(list).SelectByText("Active");
                list.Submit();

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

        public void CsvToDb(string refId, string connectionString)
        {
            var filename = $"{FilesFolder}\\FileExchange_Response_{refId}.csv";

            var listings = CsvToListings(filename);

            using (var db = GetDb(connectionString))
            {
                // There is no save bulk. Only insert bulk. We want to make sure we insert or update existing
                foreach (var listing in listings)
                {
                    db.Save(listing);
                }
            }
        }

        private List<Listing> CsvToListings(string filename)
        {
            var result = new List<Listing>();

            var reader = new StreamReader(File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
            if (reader.EndOfStream)
            {
                return null;
            }

            var headers = reader.ReadLine().Split(',');

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                var lineParts = line.Split(',');

                result.Add(new Listing()
                {
                    EbayId = lineParts[0],
                    Asin = lineParts[1],
                    Quantity = int.Parse(lineParts[5]),
                    Purchases = int.Parse(lineParts[6]),
                    Price = double.Parse(lineParts[8].Trim('$')),
                    StartDate = string.IsNullOrWhiteSpace(lineParts[9]) ? (DateTime?) null : DateTime.Parse(lineParts[9]),
                    EndDate = string.IsNullOrWhiteSpace(lineParts[10]) ? (DateTime?) null : DateTime.Parse(lineParts[10]),
                    Title = lineParts[13],
                    Category = lineParts[15],
                });
            }

            return result;
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

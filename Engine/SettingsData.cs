using System.Configuration;

namespace Engine
{
    public class SettingsData
    {
        public SettingsData()
        {
            EbayUser = ConfigurationManager.AppSettings["EbayUser"];
            EbayPassword = ConfigurationManager.AppSettings["EbayPassword"];
            Database = ConfigurationManager.AppSettings["Database"];
            CloudinaryAppName = ConfigurationManager.AppSettings["CloudinaryAppName"];
            CloudinaryKey = ConfigurationManager.AppSettings["CloudinaryKey"];
            CloudinarySecret = ConfigurationManager.AppSettings["CloudinarySecret"];
            CloudinaryWatermarkId = ConfigurationManager.AppSettings["CloudinaryWatermarkId"];
            WaitForListingFileSeconds = int.Parse(ConfigurationManager.AppSettings["WaitForListingFileSeconds"]);
        }

        public string EbayUser { get; set; }
        public string EbayPassword { get; set; }
        public string Database { get; set; }
        public string CloudinaryAppName { get; set; }
        public string CloudinaryKey { get; set; }
        public string CloudinarySecret { get; set; }
        public string CloudinaryWatermarkId { get; set; }
        public int WaitForListingFileSeconds { get; set; }

        public string DownloadRefId { get; set; }
        public string DownloadUpcRefId { get; set; }
        public string RevisedFileToUpload { get; set; }
        public string UploadRefId { get; set; }
        public string UploadResult { get; set; }
    }
}
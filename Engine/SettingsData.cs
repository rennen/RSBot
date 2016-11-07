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
            WaitForDownloadSeconds = int.Parse(ConfigurationManager.AppSettings["WaitForDownloadSeconds"]);
            WaitForUploadSeconds = int.Parse(ConfigurationManager.AppSettings["WaitForUploadSeconds"]);
            AmazonAssociateId = ConfigurationManager.AppSettings["AmazonAssociateId"];
            AmazonKeyId = ConfigurationManager.AppSettings["AmazonKeyId"];
            AmazonKeySecret = ConfigurationManager.AppSettings["AmazonKeySecret"];
            AmazonOptimizeImagesOnlyForNewProducts = bool.Parse(ConfigurationManager.AppSettings["AmazonOptimizeImagesOnlyForNewProducts"]);
        }

        public string EbayUser { get; set; }
        public string EbayPassword { get; set; }
        public string Database { get; set; }
        public string AmazonAssociateId { get; set; }
        public string AmazonKeyId { get; set; }
        public string AmazonKeySecret { get; set; }
        public bool AmazonOptimizeImagesOnlyForNewProducts { get; set; }
        public string CloudinaryAppName { get; set; }
        public string CloudinaryKey { get; set; }
        public string CloudinarySecret { get; set; }
        public string CloudinaryWatermarkId { get; set; }
        public int WaitForDownloadSeconds { get; set; }
        public int WaitForUploadSeconds { get; set; }

        public string DownloadRefId { get; set; }
        public string DownloadUpcRefId { get; set; }
        public string RevisedFileToUpload { get; set; }
        public string UploadRefId { get; set; }
        public string UploadResult { get; set; }
    }
}
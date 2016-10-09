using System;
using Engine;

namespace RSBot
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly AutomationEngine engine;

        public Form()
        {
            InitializeComponent();
            engine = new AutomationEngine();
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            txtDownloadRefId.Text = engine.PrepareDownload(txtUsername.Text, txtPassword.Text);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            engine.Download(txtUsername.Text, txtPassword.Text, txtDownloadRefId.Text);
        }

        private void btnToDb_Click(object sender, EventArgs e)
        {
            engine.CsvToDb(txtDownloadRefId.Text, txtDbConnectionString.Text);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            txtUploadRefId.Text = engine.UploadRevised(txtDbConnectionString.Text, txtUsername.Text, txtPassword.Text);
        }

        private void btnVerifyUpload_Click(object sender, EventArgs e)
        {
            engine.DownloadUploadVerification(txtUsername.Text, txtPassword.Text, txtUploadRefId.Text);
        }

        private void tnVerifyNoErrors_Click(object sender, EventArgs e)
        {
            txtUploadResult.Text = engine.VerifyNoErrors(txtUploadRefId.Text).ToString();
        }
    }
}

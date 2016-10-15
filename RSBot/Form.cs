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
            engine.ImportListings(txtDownloadRefId.Text, txtDbConnectionString.Text);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            txtUploadRefId.Text = engine.UploadRevised(txtDbConnectionString.Text, txtUsername.Text, txtPassword.Text);
        }

        private void btnVerifyUpload_Click(object sender, EventArgs e)
        {
            engine.DownloadUploadVerification(txtUsername.Text, txtPassword.Text, txtUploadRefId.Text);
        }

        private void btnVerifyUploadNoErrors_Click(object sender, EventArgs e)
        {
            txtUploadResult.Text = engine.VerifyUploadNoErrors(txtUploadRefId.Text).ToString();
        }

        private void btnPrepareDownloadUpc_Click(object sender, EventArgs e)
        {
            txtDownloadUPCRefId.Text = engine.PrepareDownload(txtUsername.Text, txtPassword.Text, true);
        }

        private void btnDownloadUpc_Click(object sender, EventArgs e)
        {
            engine.Download(txtUsername.Text, txtPassword.Text, txtDownloadUPCRefId.Text);
        }

        private void btnImportUpcCodes_Click(object sender, EventArgs e)
        {
            engine.ImportUpcCodes(txtDownloadUPCRefId.Text, txtDbConnectionString.Text);
        }

        private void btnDownloadImages_Click(object sender, EventArgs e)
        {
            engine.DownloadImages(txtDbConnectionString.Text);
        }
    }
}

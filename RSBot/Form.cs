using System;
using Engine;

namespace RSBot
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly AutomationEngine engine;
        private readonly Workflow workflow;

        public Form()
        {
            InitializeComponent();
            engine = new AutomationEngine();

            workflow = new Workflow();
            workflow.Add(chk1, pg1, () => { });
            workflow.Add(chk2, pg2, () => { });
            workflow.Add(chk3, pg3, () => { });
            workflow.Add(chk4, pg4, () => { });
            workflow.Add(chk5, pg5, () => { });
            workflow.Add(chk6, pg6, () => { });
            workflow.Add(chk7, pg7, () => { });
            workflow.Add(chk8, pg8, () => { });
            workflow.Add(chk9, pg9, () => { });
            workflow.Add(chk10, pg10, () => { });
            workflow.Add(chk11, pg11, () => { });
            workflow.Add(chk12, pg12, () => { });
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

        private void btnOptimizeImages_Click(object sender, EventArgs e)
        {
            engine.OptimizeImages(txtDbConnectionString.Text, txtCloudinaryAppName.Text, txtCloudinaryKey.Text,
                txtCloudinarySecret.Text);
        }

        private void btnShowSettings_Click(object sender, EventArgs e)
        {
            splitContainer.Panel1Collapsed = !splitContainer.Panel1Collapsed;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            workflow.Start();
        }
    }
}

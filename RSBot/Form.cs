using System;
using System.Linq;
using Engine;

namespace RSBot
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly AutomationEngine engine;
        private readonly Workflow workflow;
        private readonly SettingsData settingsData;

        public Form()
        {
            InitializeComponent();

            settingsData = new SettingsData();
            settingsGrid.SelectedObject = settingsData;

            engine = new AutomationEngine(settingsData);

            workflow = new Workflow();

            workflow.Add(stepPrepareListingDownload, engine.PrepareDownloadListing);
            workflow.Add(stepWaitForListingDownload, engine.WaitForFile);
            workflow.Add(stepDownloadListing, engine.DownloadListing);
            workflow.Add(stepImportListings, engine.ImportListings);

            workflow.Add(stepPrepareUpcDownload, engine.PrepareDownloadUpc);
            workflow.Add(stepWaitUpcFile, engine.WaitForFile);
            workflow.Add(stepDownloadUpc, engine.DownloadUpc);
            workflow.Add(stepImportUpcs, engine.ImportUpcs);

            workflow.Add(stepDownloadImages, engine.DownloadImages);
            workflow.Add(stepOptimizeImages, engine.OptimizeImages);
            workflow.Add(stepOptimizeTitles, engine.OptimizeTitles);

            workflow.Add(stepPrepareRevisedFile, engine.PrepareRevisedFile);
            workflow.Add(stepUploadRevised, engine.UploadRevised);
            workflow.Add(stepDownloadVerificationForUpload, engine.DownloadUploadVerification);
            workflow.Add(stepUploadVerify, engine.VerifyUploadNoErrors);

            //workflow.Add(chk8, pg8, () => engine.DownloadImages());

            //workflow.Add(chk9, pg9, () => { });

            //workflow.Add(chk10, pg10, () => engine.OptimizeImages());

            //workflow.Add(chk11, pg11, () => engine.UploadRevised());

            //workflow.Add(chk12, pg12, () => engine.DownloadUploadVerification());

            //workflow.Add(chk13, pg13, () => engine.VerifyUploadNoErrors());
        }

        private void btnShowSettings_Click(object sender = null, EventArgs e = null)
        {
            splitContainer.Panel1Collapsed = !splitContainer.Panel1Collapsed;
        }

        private void selectAll_Click(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            foreach (var step in workflow.Steps.Where(step => step.Enabled))
            {
                step.Checked = true;
            }
        }

        private void selectNone_Click(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            foreach (var step in workflow.Steps.Where(step => step.Enabled))
            {
                step.Checked = false;
            }
        }

        private void btnStart_Click(object sender = null, EventArgs e = null)
        {
            workflow.Run();
        }
    }
}

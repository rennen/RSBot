using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
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
            workflow.Add(stepWaitForListingDownload, engine.WaitForDownloadFile);
            workflow.Add(stepDownloadListing, engine.DownloadListing);
            workflow.Add(stepImportListings, engine.ImportListings);

            workflow.Add(stepPrepareUpcDownload, engine.PrepareDownloadUpc);
            workflow.Add(stepWaitUpcFile, engine.WaitForDownloadFile);
            workflow.Add(stepDownloadUpc, engine.DownloadUpc);
            workflow.Add(stepImportUpcs, engine.ImportUpcs);

            workflow.Add(stepOptimizeImages, engine.OptimizeImages);
            workflow.Add(stepOptimizeTitles, engine.OptimizeTitles);

            workflow.Add(stepPrepareRevisedFile, engine.PrepareRevisedFile);
            workflow.Add(stepUploadRevised, engine.UploadRevised);
            workflow.Add(stepWaitForUpload, engine.WaitForUploadFile);
            workflow.Add(stepDownloadVerificationForUpload, engine.DownloadUploadVerification);
            workflow.Add(stepUploadVerify, engine.VerifyUploadNoErrors);

            var timer = new Timer { Interval = 100 };
            timer.Tick += OnTick;
            timer.Start();
        }

        private void OnTick(object sender, EventArgs eventArgs)
        {
            if (workflow.Elapsed.HasValue)
            {
                labelElapsed.Text = workflow.Elapsed.Value.ToString(@"mm\:ss\.fff");
            }
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

        private void OnError(object sender, EventArgs<string> args)
        {
            txtLog.Text += $"Warning:\t{args.Content}" + Environment.NewLine;
        }

        private void OnWarning(object sender, EventArgs<string> args)
        {
            txtLog.Text += $"Warning:\t{args.Content}" + Environment.NewLine;
        }
    }
}

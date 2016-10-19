using System;
using System.Collections;
using System.Configuration;
using System.Drawing;
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

            workflow.Add(chk1, pg1, () => { });

            workflow.Add(chk2, pg2, () => engine.PrepareDownloadListing());

            workflow.Add(chk3, pg3, () => engine.DownloadListing());

            workflow.Add(chk4, pg4, () => engine.ImportListings());

            workflow.Add(chk5, pg5, () => engine.PrepareDownloadUpc());

            workflow.Add(chk6, pg6, () => engine.DownloadUpc());

            workflow.Add(chk7, pg7, () => engine.ImportUpcCodes());

            workflow.Add(chk8, pg8, () => engine.DownloadImages());

            workflow.Add(chk9, pg9, () => { });

            workflow.Add(chk10, pg10, () => engine.OptimizeImages());

            workflow.Add(chk11, pg11, () => engine.UploadRevised());

            workflow.Add(chk12, pg12, () => engine.DownloadUploadVerification());

            workflow.Add(chk13, pg13, () => engine.VerifyUploadNoErrors());
        }

        private void btnShowSettings_Click(object sender = null, EventArgs e = null)
        {
            splitContainer.Panel1Collapsed = !splitContainer.Panel1Collapsed;
        }

        private void selectAll_Click(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            foreach (var step in workflow.Steps.Where(step => step.StepCheckBox.Enabled))
            {
                step.StepCheckBox.Checked = true;
            }
        }

        private void selectNone_Click(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            foreach (var step in workflow.Steps.Where(step => step.StepCheckBox.Enabled))
            {
                step.StepCheckBox.Checked = false;
            }
        }

        private void btnStart_Click(object sender = null, EventArgs e = null)
        {
            workflow.Run();
        }
    }
}

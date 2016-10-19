using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace RSBot
{
    public partial class StepControl : UserControl, IActionController
    {
        public StepControl()
        {
            InitializeComponent();

            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
        }

        [Browsable(true)]
        public event ActionControllerEvents.InvokeActionHandler OnAction;

        [Browsable(true)]
        public string Description
        {
            get { return checkBox.Text; }
            set { checkBox.Text = value; }
        }

        [Browsable(true)]
        public bool Checked
        {
            get { return checkBox.Checked; }
            set { checkBox.Checked = value; }
        }

        [Browsable(true)]
        public int ProgressBarValue
        {
            get { return progressBar.Value; }
            set { progressBar.Value = value; }
        }

        public Task GetTask()
        {
            return new Task(() =>
            {
                Progress(0);
                OnAction?.Invoke(this, new EventArgs<IActionController> {Content = this});
                Progress(100);
            });

        }

        public void Progress(int percetangeCopleted)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Progress(percetangeCopleted)));
                return;
            }

            ProgressBarValue = percetangeCopleted;
        }

        public void ReportError(string message)
        {
            
        }
    }
}

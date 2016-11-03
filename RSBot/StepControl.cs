using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace RSBot
{
    public partial class StepControl : UserControl, IActionController
    {
        public delegate void dlgReport(object sender, EventArgs<string> message);

        private readonly List<string> errors;

        private readonly List<string> warnings;

        private DateTime started;

        public StepControl()
        {
            InitializeComponent();
            errors = new List<string>();
            warnings = new List<string>();
        }

        [Browsable(true)]
        public event ActionControllerEvents.InvokeActionHandler OnAction;

        [Browsable(true)]
        public event dlgReport OnError;

        [Browsable(true)]
        public event dlgReport OnWarning;

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
                StartProgress();
                try
                {
                    OnAction?.Invoke(this, new EventArgs<IActionController> {Content = this});
                    StopProgress(true);
                }
                catch (Exception ex)
                {
                    ReportError(ex.Message);
                    StopProgress(false);
                }
            });
        }

        public void StartProgress()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(StartProgress));
                return;
            }

            progressBar.Style = ProgressBarStyle.Marquee;
            started = DateTime.Now;
            labelStatus.Text = @"Started";
        }

        public void StopProgress(bool success)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => StopProgress(success)));
                return;
            }

            progressBar.Style = ProgressBarStyle.Continuous;
            var secondsStr = $"({DateTime.Now.Subtract(started).TotalSeconds} seconds)";
            labelStatus.Text = success ? $@"Success {secondsStr}" : $@"Failed {secondsStr}";
        }

        public void ReportError(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ReportError(message)));
                return;
            }

            errors.Add(message);
            OnError?.Invoke(this, new EventArgs<string>(message));

            var allMessages = errors.Aggregate((s, s1) => s + "\n" + s1);
            errorProvider.SetError(labelStatus, allMessages);
        }

        public void ReportWarning(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ReportWarning(message)));
                return;
            }

            warnings.Add(message);
            OnWarning?.Invoke(this, new EventArgs<string>(message));

            var allMessages = warnings.Aggregate((s, s1) => s + "\n" + s1);
            warningProvider.SetError(labelStatus, allMessages);
        }
    }
}

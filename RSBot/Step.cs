using System;
using System.Windows.Forms;

namespace RSBot
{
    public class Step
    {
        public Action action;

        public Step(CheckBox checkBox, ProgressBar progressbar, Action action)
        {
            StepCheckBox = checkBox;
            StepProgressBar = progressbar;
            this.action = action;

            progressbar.Minimum = 0;
            progressbar.Maximum = 100;
        }

        public CheckBox StepCheckBox { get; }
        public ProgressBar StepProgressBar { get; }

        public void Run()
        {
            StepProgressBar.Value = 0;
            action();
            StepProgressBar.Value = 100;
        }

        public void Progress(int value)
        {
            StepProgressBar.Value = value;
        }
    }
}
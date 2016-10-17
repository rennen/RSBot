using System;
using System.Windows.Forms;

namespace RSBot
{
    public class Step
    {
        public Step(CheckBox checkBox, ProgressBar proessbar, Action action)
        {
            StepCheckBox = checkBox;
            StepProgressBar = proessbar;
            Action = action;
        }

        public CheckBox StepCheckBox { get; }
        public ProgressBar StepProgressBar { get; }

        public Action Action { get; }
    }
}
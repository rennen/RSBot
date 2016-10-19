using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RSBot
{
    public class Workflow
    {
        private readonly List<Step> steps;

        public Workflow()
        {
            steps = new List<Step>();
        }

        public IEnumerable<Step> Steps => steps.AsReadOnly();

        public void Add(CheckBox checkBox, ProgressBar proessbar, Action action)
        {
            Add(new Step(checkBox, proessbar, action));
        }

        public void Add(Step step)
        {
            steps.Add(step);
        }

        public void Run()
        {            
            foreach (var step in steps.Where(step => step.StepCheckBox.Checked))
            {
                step.Run();
            }
        }
    }
}
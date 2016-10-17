using System;
using System.Collections.Generic;
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

        public void Start()
        {
            foreach (var step in steps)
            {
                step.Action();
            }
        }
    }
}
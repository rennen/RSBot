using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Engine;

namespace RSBot
{
    public class Workflow
    {
        private readonly List<StepControl> steps;
        private Stopwatch stopwatch;

        public Workflow()
        {
            steps = new List<StepControl>();
        }

        public IEnumerable<StepControl> Steps => steps.AsReadOnly();

        public TimeSpan? Elapsed => stopwatch?.Elapsed;

        public void Add(StepControl step, Action<IActionController> action)
        {
            step.OnAction += (sender, args) => action(args.Content);
            steps.Add(step);
        }

        public void Run()
        {
            var tasks = steps.Where(step => step.Checked).Select(step => step.GetTask()).ToArray();

            var root = tasks[0];
            for (var i = 1; i < tasks.Length; i++)
            {
                var index = i;
                tasks[i - 1].ContinueWith(task => tasks[index].Start());
            }

            stopwatch = new Stopwatch();
            stopwatch.Start();
            tasks.Last().ContinueWith(task => stopwatch.Stop());

            root.Start();
        }
    }
}
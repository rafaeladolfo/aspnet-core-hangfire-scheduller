using scheduller.Job.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scheduller.Job.Implementation
{
    public class SimpleJob : IJobRunner
    {
        public async Task RunJob()
        {
            var task = new Task(new Action(Write));
            task.Start();
        }

        private void Write()
        {
            Console.Write("This task wrote something");
        }
    }
}

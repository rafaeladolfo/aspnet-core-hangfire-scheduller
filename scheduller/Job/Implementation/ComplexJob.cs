using Microsoft.Extensions.Options;
using scheduller.data.Domain;
using scheduller.data.Services.Implementation;
using scheduller.data.Services.Interfaces;
using scheduller.Job.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scheduller.Job.Implementation
{
    public class ComplexJob : IJobRunner
    {
        public async Task RunJob()
        {            
            var task = new Task(new Action(SaveData));
            task.Start();
        }

        public void SaveData()
        {            
            IComplexJobService complexJobService = new ComplexJobService();
            complexJobService.SaveComplexJob();
        }
    }
}

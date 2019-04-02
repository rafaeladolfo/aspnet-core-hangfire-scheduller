using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scheduller.Job.Interfaces
{
    interface IJobRunner
    {
        Task RunJob();
    }
}

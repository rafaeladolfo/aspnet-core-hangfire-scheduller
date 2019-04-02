using Hangfire;
using Microsoft.AspNetCore.Mvc;
using scheduller.Job.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scheduller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleJobsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            var myJob = new SimpleJob();
            RecurringJob.AddOrUpdate(() => myJob.RunJob(), Cron.Minutely());

            return "Just added a simple job."; //simple simples bem simples
        }
    }
}

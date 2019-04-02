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
    public class ComplexJobsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            var myJob = new ComplexJob();
            RecurringJob.AddOrUpdate(() => myJob.RunJob(), Cron.Minutely());

            return "Just added a very complex job.";
        }
    }
}

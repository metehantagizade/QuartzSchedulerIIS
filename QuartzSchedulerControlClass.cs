using System;
using System.Collections.Generic;
using QuartzSchedulerIIS.Controllers;
using System.Linq;
using System.Web;
using Quartz;
using Quartz.Impl;
using QuartzSchedulerIIS.Models;

namespace QuartzSchedulerIIS.Models
{
    public class QuartzSchedulerControl : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            // Code that should be executed
        }
    }
    public class QuartzSchedulerControlClass
    {
        public static void QuartzSchedulerControlStart()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();

            IJobDetail job = JobBuilder.Create<QuartzSchedulerControl>().Build();

            ITrigger trigger = TriggerBuilder.Create().WithCronSchedule("0 0 23 1/1 * ? *").Build(); //every day at 23:00

            scheduler.ScheduleJob(job, trigger);

        }
    }


}
using Quartz;
using Quartz.Impl;
using Quartz.Logging;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_QuartzNet
{
    /*
     Quartz框架的一些基础概念解释：
 　　Scheduler     作业调度器。
 　　IJob             作业接口，继承并实现Execute， 编写执行的具体作业逻辑。
　　 JobBuilder       根据设置，生成一个详细作业信息(JobDetail)。
　　 TriggerBuilder   根据规则，生产对应的Trigger
         
    */
    public static class QuartzOperation
    {

        public static void Start()
        {
            LogProvider.SetCurrentLogProvider(new ConsoleLogProvider());

            RunExamples().GetAwaiter().GetResult();

        }

        private static async Task RunExamples()
        {

            try
            {
                //创建scheduler,工厂模式
                NameValueCollection props = new NameValueCollection
                {
                    {"quartz.serializer.type","binary" }
                };

                StdSchedulerFactory factory = new StdSchedulerFactory(props);
                IScheduler scheduler = await factory.GetScheduler();

                //start it 
                await scheduler.Start();

                //定义job,绑定到myjob
                IJobDetail job = JobBuilder.Create<MyJob>()
                    .WithIdentity("job1", "group1")
                    .Build();
                
                //设定trigger
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("trigger1", "group1")
                    .StartNow()
                    .WithSimpleSchedule(x => x
                    .WithIntervalInSeconds(10)
                    .RepeatForever())
                    .Build();

                //schedule the job using the trigger
                await scheduler.ScheduleJob(job, trigger);

                await Task.Delay(TimeSpan.FromSeconds(60*10));
                await scheduler.Shutdown();

            }
            catch (Exception se)
            {
                Console.WriteLine(se);
            }

        }




    }
}

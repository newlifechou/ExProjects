using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_QuartzNet
{
    /// <summary>
    /// 需要执行的Job
    /// </summary>
    public class MyJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Console.Out.WriteLineAsync($"Job has been done at {DateTime.Now}");
        }
    }
}

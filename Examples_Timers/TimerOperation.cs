using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples_Timers
{
    /*
     多线程计时器
        1：System.Threading.Timer
        2：System.Timers.Timer
        特殊目的的单线程计时器：
        1：System.Windows.Forms.Timer（Windows Forms Timer）
        2：System.Windows.Threading.DispatcherTimer(WPF timer);
         */
    static class TimerOperation
    {
        /// <summary>
        /// System.Threading.Timer 是一个简单、 轻型计时器，它使用回调方法，并由线程池线程提供服务。
        /// </summary>
        public static void ThreadingTimer()
        {
            Timer timer = new Timer(Do,null,2000,500);
            //这里必须等待，不然timer就会被回收
            Console.ReadLine();

            timer.Dispose();
        }

        private static void Do(object state)
        {
            Job.Show();
        }

        /// <summary>
        /// System.Windows.Forms.Timer 是使用 Windows 窗体的更好选择
        /// ！！！！必须再WindowsForm中才会工作
        /// </summary>
        public static void WindowsFormsTimer()
        {
            Console.WriteLine("Windows Forms Timer");
            var timer =new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Job.Show();
        }

        /// <summary>
        /// 对threading timer的包装，组件化了，更方便使用了
        /// </summary>
        public static void SystemTimers()
        {
            var timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Job.Show();
        }
    }
}

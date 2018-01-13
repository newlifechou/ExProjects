using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Src
{
    class SyncThread
    {
        public void One()
        {
            for (int i = 0; i < 10; i++)
            {
                Counter c = new Counter();
                var t1 = new Thread(() => TestCounter(c));
                var t2 = new Thread(() => TestCounter(c));
                var t3 = new Thread(() => TestCounter(c));

                t1.Priority = ThreadPriority.Highest;
                t3.Priority = ThreadPriority.Lowest;

                t1.Start();
                t2.Start();
                t3.Start();

                t1.Join();
                t2.Join();
                t3.Join();
                Console.WriteLine($"Sync Completed={c.ValueA}");
            }
        }

        public void Two()
        {
            const string MutexName = "xszhou";
            using (var m = new Mutex(false, MutexName))
            {
                if (!m.WaitOne(TimeSpan.FromSeconds(5),false))
                {
                    Console.WriteLine("second instance is running!");
                }
                else
                {
                    Console.WriteLine("Running!");
                    Console.ReadLine();
                    m.ReleaseMutex();
                }


            }
        }

        public void Three()
        {
            for (int i = 0; i < 10; i++)
            {
                string threadName = "Thread" + i;
                int second = 2 + 2 * i;
                var t = new Thread(() => AccessDabase(threadName, second));
                t.Start();
            }
        }

        public void Four()
        {

            var t = new Thread(() => Process(10));
            t.Start();

            Console.WriteLine("waiting for another thread to complete work");
            _workedEvent.WaitOne();
            Console.WriteLine("first misson completed");
            Console.WriteLine("Performing another operation on a main thread");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            _mainEvent.Set();
            Console.WriteLine("now running the second operation");
            _workedEvent.WaitOne();
            Console.WriteLine("second operation is completed");



        }
        private static AutoResetEvent _workedEvent = new AutoResetEvent(false);
        private static AutoResetEvent _mainEvent = new AutoResetEvent(false);

        private void Process(int seconds)
        {
            Console.WriteLine("Starting running a long work");
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
            Console.WriteLine("Work is done!");
            _workedEvent.Set();
            Console.WriteLine("wait for a main thread to complete its task");
            _mainEvent.WaitOne();
            Console.WriteLine("starting second operation");
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
            Console.WriteLine("Work is done!");
            _workedEvent.Set();
        }

        private static SemaphoreSlim _semaphore = new SemaphoreSlim(4);
        private void AccessDabase(string threadName,int seconds)
        {
            Console.WriteLine( "{0} waits to access database",threadName);
            _semaphore.Wait();
            Console.WriteLine("{0} waits to granted a database",threadName);
            Thread.Sleep(seconds * 1000);
            Console.WriteLine("{0} is completed",threadName);
            _semaphore.Release();
        }


        private void TestCounter(Counter c)
        {
            for (int i = 0; i < 100000; i++)
            {
                //Swap(ref c.ValueA, ref c.ValueB);
                //Swap(ref c.ValueA, ref c.ValueB);

                int orginal = Interlocked.Exchange(ref c.ValueA, 200);
                if (orginal==100)
                {
                    Interlocked.Exchange(ref c.ValueA, 100);
                }


                
                //Interlocked.Increment(ref c.Count2);
                //Interlocked.Decrement(ref c.Count2);
                //c.Count2++;
                //c.Count2--;
            }
        }

        private void Swap(ref int a, ref int b)
        {
            int tempValue = a;
            a = b;
            b = tempValue;
        }

    }
}

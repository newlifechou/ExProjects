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
                if (!m.WaitOne(TimeSpan.FromSeconds(5), false))
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

        public void Five()
        {
            var t1 = new Thread(() => TravelThroughGates("Thread1", 5));
            var t2 = new Thread(() => TravelThroughGates("Thread2", 6));
            var t3 = new Thread(() => TravelThroughGates("Thread3", 7));
            t1.Start();
            t2.Start();
            t3.Start();

            Thread.Sleep(TimeSpan.FromSeconds(6));
            Console.WriteLine("the gates are now open");
            _mainEvent2.Set();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            _mainEvent2.Reset();
            Console.WriteLine("the gate is closed now");

            Thread.Sleep(TimeSpan.FromSeconds(10));
            Console.WriteLine("the gates are now open");
            _mainEvent2.Set();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            _mainEvent2.Reset();
            Console.WriteLine("the gate is closed now");
        }


        public void Six()
        {
            for (int i = 0; i < 6; i++)
            {
                var t = new Thread(() => PerformOperation("msg" + i, i));
                t.Start();
            }
            _countdown.Wait();
            _countdown.Dispose();
        }

        public void Seven()
        {
            var t1 = new Thread(() => PlayMusic("the guitar", "play one", 5));
            var t2 = new Thread(() => PlayMusic("the piano", "play two", 2));
            t1.Start();
            t2.Start();

        }

        public void Eight()
        {
            new Thread(ReadDict) { IsBackground = true }.Start();
            new Thread(ReadDict) { IsBackground = true }.Start();
            new Thread(ReadDict) { IsBackground = true }.Start();
            new Thread(ReadDict) { IsBackground = true }.Start();
            new Thread(()=>WriteDict("Thread1")) { IsBackground = true }.Start();
            new Thread(() => WriteDict("Thread2")) { IsBackground = true }.Start();



        }

        public void Nine()
        {
            var t1 = new Thread(UserModeWait);
            var t2 = new Thread(HybridSpinWait);
            t1.Start();
            Console.WriteLine("running in user mode");
            Thread.Sleep(20);
            _isCompleted = true;
            Thread.Sleep(1000);
            _isCompleted = false;
            Console.WriteLine("running in hybrid mode");
            t2.Start();
            Thread.Sleep(5);
            _isCompleted = true;




        }
        private volatile bool _isCompleted = false;
        private void UserModeWait()
        {
            while (!_isCompleted)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            Console.WriteLine("Waiting is complete");
        }
        private void HybridSpinWait()
        {
            var w = new SpinWait();
            while (!_isCompleted)
            {
                w.SpinOnce();
                Console.WriteLine(w.NextSpinWillYield);
            }
            Console.WriteLine("Waiting is completed");

        }





        private ReaderWriterLockSlim _rw = new ReaderWriterLockSlim();
        private Dictionary<int, int> _items = new Dictionary<int, int>();
        private void ReadDict()
        {
            Console.WriteLine("Read the content of dictionary");
            while (true)
            {
                try
                {
                    _rw.EnterReadLock();
                    foreach (var item in _items.Keys)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.1));
                    }
                }
                finally
                {
                    _rw.ExitReadLock();
                }

            }
        }
        private void WriteDict(string threadName)
        {
            Console.WriteLine("Write the content of dictionary");
            while (true)
            {
                try
                {
                    int newKey = new Random().Next(250);
                    _rw.EnterUpgradeableReadLock();
                    if (!_items.ContainsKey(newKey))
                    {
                        try
                        {
                            _rw.EnterWriteLock();
                            _items[newKey] = 1;
                            Console.WriteLine($"{newKey}-{threadName}");
                        }
                        finally
                        {
                            _rw.ExitWriteLock();
                        }
                    }

                }
                finally
                {
                    _rw.ExitUpgradeableReadLock();
                }
            }

        }

        private static Barrier _barrier = new Barrier(2, b => Console.WriteLine("end of phase {0}", b.CurrentPhaseNumber + 1));
        public void PlayMusic(string name, string msg, int seconds)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("*********");
                Thread.Sleep(TimeSpan.FromSeconds(seconds));
                Console.WriteLine($"{name} starts to {msg}");
                Thread.Sleep(TimeSpan.FromSeconds(seconds));
                Console.WriteLine($"{name} ends to {msg}");
                _barrier.SignalAndWait();

            }
        }








        private static CountdownEvent _countdown = new CountdownEvent(6);
        private void PerformOperation(string msg, int seconds)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
            Console.WriteLine(msg);
            _countdown.Signal();

        }

        private static ManualResetEventSlim _mainEvent2 = new ManualResetEventSlim(false);
        private void TravelThroughGates(string threadName, int seconds)
        {
            Console.WriteLine($"ThreadName:{threadName}");
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
            Console.WriteLine($"{threadName} waits the gate to open");
            _mainEvent2.Wait();
            Console.WriteLine($"{threadName} enters the gates");

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
        private void AccessDabase(string threadName, int seconds)
        {
            Console.WriteLine("{0} waits to access database", threadName);
            _semaphore.Wait();
            Console.WriteLine("{0} waits to granted a database", threadName);
            Thread.Sleep(seconds * 1000);
            Console.WriteLine("{0} is completed", threadName);
            _semaphore.Release();
        }


        private void TestCounter(Counter c)
        {
            for (int i = 0; i < 100000; i++)
            {
                //Swap(ref c.ValueA, ref c.ValueB);
                //Swap(ref c.ValueA, ref c.ValueB);

                int orginal = Interlocked.Exchange(ref c.ValueA, 200);
                if (orginal == 100)
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

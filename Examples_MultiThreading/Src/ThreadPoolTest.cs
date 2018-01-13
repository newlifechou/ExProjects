using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace MultiThreading.Src
{
    class ThreadPoolTest
    {
        public void One()
        {
            int threadid = 0;
            RunOnThreadPool poolDelegate = Test;
            var t = new Thread(() => Test(out threadid));
            t.Start();
            t.Join();
            Console.WriteLine($"thread id {threadid}");

            //之前的没有在线程池，之后的在线程池

            IAsyncResult r = poolDelegate.BeginInvoke(out threadid, CallBack, "aa delegate async call");
            r.AsyncWaitHandle.WaitOne();

            string result = poolDelegate.EndInvoke(out threadid, r);
            Console.WriteLine(result);
            Thread.Sleep(2000);


        }

        public void Two()
        {
            const int x = 1;
            const int y = 2;
            const string lambdaState = "lambda state 2";
            ThreadPool.QueueUserWorkItem(AsyncOperation);
            Thread.Sleep(3000);
            ThreadPool.QueueUserWorkItem(AsyncOperation, "async state");
            Thread.Sleep(3000);

            ThreadPool.QueueUserWorkItem(state =>
            {
                Console.WriteLine(state);
                Console.WriteLine($"worker  thread is {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(3000);
            }, "lambda state");

            ThreadPool.QueueUserWorkItem(state =>
            {
                Console.WriteLine($"{x + y}-{lambdaState}");
                Console.WriteLine($"worker  thread is {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(3000);
            }, "lambda state");


        }

        public void Three()
        {
            const int numberOfOperations = 500;
            var sw = new Stopwatch();
            sw.Start();
            UseThreads(numberOfOperations);

            sw.Stop();
            Console.WriteLine($"Thread={sw.ElapsedMilliseconds}");

            sw.Reset();
            sw.Start();
            UseThreadPool(numberOfOperations);
            sw.Stop();
            Console.WriteLine($"ThreadPool={sw.ElapsedMilliseconds}");




        }

        public void Four()
        {
            using (var cts = new CancellationTokenSource())
            {
                CancellationToken token = cts.Token;
                ThreadPool.QueueUserWorkItem(t => AsyncOperation1(token));
                Thread.Sleep(2000);
                cts.Cancel();

            }
            using (var cts = new CancellationTokenSource())
            {
                CancellationToken token = cts.Token;
                ThreadPool.QueueUserWorkItem(t => AsyncOperation2(token));
                Thread.Sleep(2000);
                cts.Cancel();

            }
            using (var cts = new CancellationTokenSource())
            {
                CancellationToken token = cts.Token;
                ThreadPool.QueueUserWorkItem(t => AsyncOperation3(token));
                Thread.Sleep(2000);
                cts.Cancel();

            }

        }

        private void AsyncOperation1(CancellationToken token)
        {
            Console.WriteLine("start the first task");
            for (int i = 0; i < 5; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("the first task was canceled");
                    return;

                }
                Thread.Sleep(1000);


            }

            Console.WriteLine("the first task completed sucessfully");
        }
        private void AsyncOperation2(CancellationToken token)
        {
            try
            {
                Console.WriteLine("start the second task");
                for (int i = 0; i < 5; i++)
                {
                    token.ThrowIfCancellationRequested();
                    Thread.Sleep(1000);
                }

                Console.WriteLine("the second task completed sucessfully");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("the second task was canceled");
            }
        }
        private void AsyncOperation3(CancellationToken token)
        {
            bool canceltag = false;
            token.Register(() => canceltag = true);
            Console.WriteLine("start the third task");
            for (int i = 0; i < 5; i++)
            {
                if (canceltag)
                {
                    Console.WriteLine("the third task was canceled");
                    return;
                }
                Thread.Sleep(1000);
            }

            Console.WriteLine("the third task completed sucessfully");


        }


        private void UseThreads(int numberOfOperations)
        {
            using (var countDown = new CountdownEvent(numberOfOperations))
            {
                Console.WriteLine("scheduling work by creating threads");
                for (int i = 0; i < numberOfOperations; i++)
                {
                    var thread = new Thread(() =>
                      {
                          Console.Write(Thread.CurrentThread.IsThreadPoolThread);
                          //Console.WriteLine($"CurrentManagementID{Thread.CurrentThread.ManagedThreadId}");
                          Thread.Sleep(10);
                          countDown.Signal();
                      });
                    thread.Start();
                }
                countDown.Wait();
                Console.WriteLine();

            }


        }

        private void UseThreadPool(int numberOfOperations)
        {
            using (var countDown = new CountdownEvent(numberOfOperations))
            {
                Console.WriteLine("scheduling work by creating threads");
                for (int i = 0; i < numberOfOperations; i++)
                {

                    ThreadPool.QueueUserWorkItem(_ =>
                   {
                       Console.Write(Thread.CurrentThread.IsThreadPoolThread);
                       //Console.WriteLine($"CurrentManagementID{Thread.CurrentThread.ManagedThreadId}");
                       Thread.Sleep(10);
                       countDown.Signal();
                   });
                }
                countDown.Wait();
                Console.WriteLine();

            }
        }

        private void AsyncOperation(object state)
        {
            Console.WriteLine($"Operate state {state ?? "null"}");
            Console.WriteLine($"worker thread id {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);

        }




        private delegate string RunOnThreadPool(out int threadid);
        private void CallBack(IAsyncResult ar)
        {
            Console.WriteLine("starting a callback");
            Console.WriteLine($"state passed to a callback {ar.AsyncState}");
            Console.WriteLine($"is there a pool thread {Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"thread pool worker thread id {Thread.CurrentThread.ManagedThreadId}");
        }

        private string Test(out int threadId)
        {
            Console.WriteLine("Starting");
            Console.WriteLine($"is there a pool thread {Thread.CurrentThread.IsThreadPoolThread}");
            Thread.Sleep(5000);
            threadId = Thread.CurrentThread.ManagedThreadId;
            return $"thread pool worker thread id {threadId}";
        }

    }
}

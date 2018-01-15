using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Src
{
    class TaskTest
    {
        internal void One()
        {
            var t1 = new Task(() => TaskMethod("task 1"));
            var t2 = new Task(() => TaskMethod("task 2"));
            t2.Start();
            t1.Start();

            Task.Run(() => TaskMethod("task 3"));
            Task.Factory.StartNew(() => TaskMethod("task 4"));
            Task.Factory.StartNew(() => TaskMethod("task 5"), TaskCreationOptions.LongRunning);
        }

        internal void Two()
        {
            Console.WriteLine(TaskMethod2("main task"));
            Task<int> task = CreateTask("task 1");
            task.Start();
            int result = task.Result;
            Console.WriteLine($"Result is {result}");

            task = CreateTask("task 2");
            task.RunSynchronously();
            result = task.Result;
            Console.WriteLine($"Result is {result}");

            task = CreateTask("task 3");
            task.Start();
            while (!task.IsCompleted)
            {
                Console.WriteLine(task.Status);
                Thread.Sleep(500);

            }
            Console.WriteLine(task.Status);
            result = task.Result;
            Console.WriteLine($"Result is {result}");


        }


        private Task<int> CreateTask(string name)
        {
            return new Task<int>(() => TaskMethod2(name));
        }
        private int TaskMethod2(string name)
        {
            Console.WriteLine($"Task {name} is running on a thread id {Thread.CurrentThread.ManagedThreadId}, ThreadPool={Thread.CurrentThread.IsThreadPoolThread}");
            Thread.Sleep(5000);
            return 42;
        }
        private void TaskMethod(string name)
        {
            while (true)
            {
                Thread.Sleep(500);
                Console.WriteLine($"Task {name} is running on a thread id {Thread.CurrentThread.ManagedThreadId}, ThreadPool={Thread.CurrentThread.IsThreadPoolThread}");
            }
        }


    }
}

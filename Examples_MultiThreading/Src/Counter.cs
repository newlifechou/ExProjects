using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Src
{
    class Counter
    {
        private readonly object syncObject = new object();
        public int Count { get; set; }
        public void Increase()
        {
            //lock (syncObject)
            //{
            //    Count++;
            //}
            bool acquiredLock = false;
            Monitor.Enter(syncObject, ref acquiredLock);
            Count++;
            Monitor.Exit(syncObject);
        }
        public void Decrease()
        {
            lock (syncObject)
            {
                Count--;
            }
        }
    }
}

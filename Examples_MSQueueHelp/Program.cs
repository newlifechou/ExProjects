using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;

namespace Examples_MSQueueHelp
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageQueue myQueue = new MessageQueue(".\\private$\\test");

            Message m = myQueue.Receive();
            m.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
            Console.WriteLine(m.Body.ToString());
            Console.WriteLine("读取消息完毕");
            Console.Read();
        }
    }
}

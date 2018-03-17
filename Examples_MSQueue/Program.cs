using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace Examples_MSQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageQueue myQueue = new MessageQueue();
            myQueue.Path = ".\\private$\\test";

            Message msg = new Message();
            msg.Body = "Hello MS Queue";

            myQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
            myQueue.Send(msg, MessageQueueTransactionType.Single);
            Console.WriteLine("消息发送成功");

            Console.Read();
        }
    }
}

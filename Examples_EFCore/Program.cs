using System;

namespace Examples_EFCore
{
    
    class Program
    {
        static void Main(string[] args)
        {
            EFCoreOperation.Post();
            EFCoreOperation.Get();
            Console.WriteLine("main thread is running");
            Console.Read();
        }
    }
}

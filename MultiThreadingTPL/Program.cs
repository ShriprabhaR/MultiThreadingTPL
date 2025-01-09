using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingTPL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread thread1 = new Thread(MultiThreading.PrintNumbers);
            //Thread thread2 = new Thread(MultiThreading.PrintNumbers);

            //thread1.Start();
            //thread2.Start();

            //thread1.Join();
            //thread2.Join();

            //Console.WriteLine("Both threads are completed");
            Console.WriteLine("Starting parallel processing...");
            TPL.ParallelProcessing();

            Console.WriteLine("\nStarting asynchronous processing.....");
            Task.Run(() => TPL.AsynchronousProcessing()).Wait();

            Console.WriteLine("Process completed");

        }

        //static async Task Main()
        //{
        //    Task task1 = Task.Run(() => TPL.PrintNumbers());
        //    Task task2 = Task.Run(() => TPL.PrintNumbers());

        //    await Task.WhenAll(task1, task2);

        //    Console.WriteLine("Both threads are completed");

        //}
    }
}

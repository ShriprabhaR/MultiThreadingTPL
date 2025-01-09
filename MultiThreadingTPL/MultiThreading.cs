using System;
using System.Threading;

namespace MultiThreadingTPL
{
    internal class MultiThreading
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingTPL
{
    internal class TPL
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Task{Task.CurrentId}");
                Task.Delay(1000).Wait();

            }
        }

        public static void ParallelProcessing()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Parallel.ForEach(numbers, number =>
            {
                Task.Delay(1000).Wait();
                Console.WriteLine($"Processed {number} on thread {Task.CurrentId}");
            });
        }

        public static async Task<string> ProcessAsyncTask(string taskName)
        {
            Console.WriteLine($"Started {taskName} on thread {Task.CurrentId}");
            await Task.Delay(2000);
            Console.WriteLine($"Completed {taskName} on thread {Task.CurrentId}");
            return taskName;
        }
        public static async Task AsynchronousProcessing()
        {
            Task<string> task1 = ProcessAsyncTask("Task1");
            Task<string> task2 = ProcessAsyncTask("Task2");

            string result1 = await task1;
            string result2 = await task2;

            Console.WriteLine($"Result from {result1}");
            Console.WriteLine($"Result from {result2}");
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingTPL
{
    internal class FileOperation
    {
        public static async void CallMethod()
        {
            string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\BasicFile.txt";
            Task<int> task = ReadFile(path);

            Console.WriteLine("other work 1");
            Console.WriteLine("other work 2");
            Console.WriteLine("other work 3");

            int length = await task;
            Console.WriteLine("Total length: " + length);
            Console.WriteLine("After work 1");
            Console.WriteLine("After work 2");
        }

        static async Task<int> ReadFile(string file)
        {
            int length = 0;
            Console.WriteLine("file reading is stating");
            using (StreamReader reader = new StreamReader(file))
            {
                string s = await reader.ReadToEndAsync();
                length = s.Length;
            }
            Console.WriteLine("File reading is completed");
            return length;
        }
    }
}

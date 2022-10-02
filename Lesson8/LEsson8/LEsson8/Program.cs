using System;
using System.IO;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {

            //string path = @"D:\\Study\\NET17\\Lesson8\\LEsson8\\LEsson8\\temp.txt";
            //StreamReader reader = new StreamReader(path);
            //// асинхронное чтение
            //async void FileReader()
            //{
            //    string? line;
            //    while ((line = await reader.ReadLineAsync()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //FileReader();
            UIStartApp.Start();
            Console.ReadKey();
        }
    }
}

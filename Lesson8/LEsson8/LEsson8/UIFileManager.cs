using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Lesson8
{
    public class UIFileManager
    {
        private static string path = @"D:\Study\NET17\Lesson8\LEsson8\LEsson8\temp.txt";
        public static void NeedStart(string user)
        {
            UIStartApp.DeleteAllString();
            if (user == "yes" || user == "Yes")
            {
                EnterPath();
                Console.WriteLine("You need to print the file ");
                FileReader(Console.ReadLine());
            }
        }
        public static void EnterPath()
        {
            Console.Write("Enter path or void ");
            string newpath = Console.ReadLine();
            UIStartApp.DeleteAllString();
            if (newpath != "")
            {
                path = $@"{newpath}";
            }
        }
        public static void FileReader(string ifNeed)
        {
            UIStartApp.DeleteAllString();
            Console.SetCursorPosition(0, 2);
            if (ifNeed == "yes" || ifNeed == "Yes")
            {
                StreamReader reader = new StreamReader(path);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Thread.Sleep(200);
                    Console.WriteLine(line);
                }
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}

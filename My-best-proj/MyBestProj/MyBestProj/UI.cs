using MyBestProj.HomeWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBestProj
{
    public class UI
    {
        public static void Start()
        {
            Table<string, string, string> list = new Table<string, string, string>();
            list.Add("first", "second", "third");
            list.Add("4", "5", "6");
            list.Add("7", "8", "9");
            list.Add("4", "9", "6");
            list.Add("71", "8", "59");
            list.Add("44", "5", "63");
            list.Add("77", "15", "91");
            list.Add("48", "5", "66");
            list.Add("7", "8", "9");


            Console.WriteLine("Enter how many page you need?");
            string pageText = Console.ReadLine();
            int page = int.Parse(pageText);

            Console.Clear();

            //while (true)
            //{
            //    AddParamInList(list);
            //    if(Console.ReadLine() == "z")
            //    {
            //        Console.Clear();
            //        break;
            //    }
            //}
            list.Print(page);
            while (true)
            {
                string choice = Console.ReadLine();
                Console.Clear();
                list.PrintPage(choice, page);
                
            }

        }
        public static void AddParamInList(Table<string, string, string> list)
        {
            Console.WriteLine("Enter param Add");

            list.Add(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
        }

    }
}

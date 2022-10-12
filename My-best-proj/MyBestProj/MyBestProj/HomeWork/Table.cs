using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyBestProj.HomeWork
{
    public class Table<T, U, V>
    {
        public Line<T, U, V> FirstLine { get; private set; }
        public Line<T, U, V> LastLine { get; private set; }
        public string FTitle { get; private set;}
        public string STitle { get; private set; }
        public string TTitle { get; private set; }
        public int Count { get; private set; }
        public int CurrentLine { get; private set; }
        public int Page { get; private set; }
        public Table()
        {
            FirstLine = null;
            LastLine = null;
            FTitle = "First";
            STitle = "Second";
            TTitle = "Third";
            Count = 0;
            Page = 0;
        }
        public Table(T firstItem, U secondItem, V thirdItem)
        {
            var item = new Line<T, U, V>(firstItem, secondItem, thirdItem);
            FirstLine = item;
            LastLine = item;
            Count = 1;
        }

        public void Add(T firstItem, U secondItem, V thirdItem)
        {
            var node = new Line<T, U, V>(firstItem, secondItem, thirdItem);

            if (LastLine != null)
            {
                LastLine.NextLine = node;
                LastLine = node;
                Count++;
            }
            else
            {
                AddFirstAndLastLine(node);
            }
        }
        public void AddTitle(string firstTitle, string secondTitle, string thirdTitle)
        {
            FTitle = firstTitle;
            STitle = secondTitle;
            TTitle = thirdTitle;
        }





        public void Print(int line)
        {
            Console.Write($"||{FTitle} ||");
            Console.Write($"{STitle} ||");
            Console.Write($"{TTitle} || \n");
            var current = FirstLine;
            int counter = 0;

            for (; counter < line; counter++)
            {
                if (current == null)
                {
                    Console.Write($"||null||");
                    Console.Write($"null||");
                    Console.Write($"null|| \n");
                }
                else
                {
                    Console.Write($"||{current.FirstItem} ||");
                    Console.Write($"{current.SecondItem} ||");
                    Console.Write($"{current.ThirdItem} || \n");

                    current = current.NextLine;
                }
            }
            Console.WriteLine($"||back||{CurrentLine}||next|| ");
            CurrentLine = counter;
            Page++;

        }
        public void PrintPage(string choice, int line)
        {
            if (choice == "next")
            {
                var current = FirstLine;
                int counter = CurrentLine;
                for(int i = 0; i < CurrentLine; i++)
                {
                    current = current.NextLine;
                }
                for (int i = 0; i < line; i++)
                {
                    if (current == null)
                    {
                        Console.Write($"||null||");
                        Console.Write($"null||");
                        Console.Write($"null|| \n");
                    }
                    else
                    {
                        Console.Write($"||{current.FirstItem} ||");
                        Console.Write($"{current.SecondItem} ||");
                        Console.Write($"{current.ThirdItem} || \n");

                        current = current.NextLine;
                    }
                }
                CurrentLine += line;
                Console.WriteLine($"||back||{Page}||next|| ");
                Page++;
            }
            else if(choice == "back")
            {
                Page--;
                var current = FirstLine;
                int counter = CurrentLine;
                for (int i = 0; i < CurrentLine - line * 2; i++)
                {
                    current = current.NextLine;
                }
                for (int i = 0; i < line; i++)
                {
                    if (current == null)
                    {
                        Console.Write($"||null||");
                        Console.Write($"null||");
                        Console.Write($"null|| \n");
                    }
                    else
                    {
                        Console.Write($"||{current.FirstItem} ||");
                        Console.Write($"{current.SecondItem} ||");
                        Console.Write($"{current.ThirdItem} || \n");

                        current = current.NextLine;
                    }
                }
                CurrentLine += line;
                Console.WriteLine($"||back||{Page}||next|| ");

            }
            else
            {

            }
        }
        private void AddFirstAndLastLine(Line<T, U, V> node)
        {
            FirstLine = node;
            LastLine = node;

            Count = 1;
        }



    }
}

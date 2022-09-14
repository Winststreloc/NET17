using System;
using System.Collections.Generic;

namespace Samostoytelny
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Enter exception");
            StartApp();
        }
        public static void StartApp()
        {
            bool endApp = false;

            while (!endApp)
            {
                string text = Console.ReadLine();
                Console.Clear();
                if (text == "all")
                {
                    RAM.AllResult();
                }
                else if (text.Contains("choice"))
                {
                    text.Trim(' ');
                    text = text[Constant.choice..];
                    Console.Write(RAM.ChoiceUser(Convert.ToInt32(text)));
                    string temp = Console.ReadLine();
                    Console.WriteLine($"{text} = {Parse.Solve(RAM.ChoiceUser(Convert.ToInt32(text)) + temp)}");
                }
                else
                {

                    Console.WriteLine($"{text} = {Parse.Solve(text)}");
                }

            }
        }
    }
}

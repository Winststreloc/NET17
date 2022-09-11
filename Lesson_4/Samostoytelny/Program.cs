using System;
using System.Collections.Generic;

namespace Samostoytelny
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Enter exception");
            bool endApp = false;
            while (!endApp)
            {
                string text = Console.ReadLine();
                if (text == "all")
                {
                    RAM.AllResult();
                }
                else if (text.Contains("choice"))
                {
                    text.Trim(' ');
                    text = text.Substring(6);
                    Console.Write(RAM.ChoiceUser(Convert.ToInt32(text)));
                }
                else
                {
                double result = Parse.Solve(text);
                Console.WriteLine(result);
                }

            }


        }
    }
}

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
            string temp = "";
            while (!endApp)
            {
                string text = temp + Console.ReadLine();
                if (text == "all")
                {
                    RAM.AllResult();
                }
                else if (text.Contains("choice"))
                {
                    text.Trim(' ');
                    text = text.Substring(6);
                    temp = RAM.ChoiceUser(Convert.ToInt32(text));
                    Console.Write(temp);
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

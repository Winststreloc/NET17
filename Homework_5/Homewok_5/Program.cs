using System;

namespace Homewok_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            while (!endApp)
            {
                Console.WriteLine(Parse.ParseCalculator(Console.ReadLine()));
                if (Console.ReadLine() == "z")
                {
                    endApp = false;
                }
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.Ex_Math
{
    class City_size
    {
        public static string Solve()
        {
            string[] city = { "Sitka, Alaska", "New York City ", "Los Angeles ", "Detroit", "Chicago ", "San Diego" };
            double[] area = { 2870.3, 302.6, 468.7, 138.8, 227.1, 325.2 };
            Console.WriteLine("City                   Area (mi.)   Equivalent to a square with:");
            for(int i = 0; i < city.Length; i++)
            {
                Console.WriteLine($"{city[i]}                   {area[i]}   {Math.Pow(area[i], 1 / 2)}");
            }
            return default;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.For_Loop
{
    class Pr_5
    {
        public static string Solve(int n)
        {
            for (int i = 0; i != n; i++)
            {
                int cube = (int)Math.Pow(i,3);
                Console.WriteLine($"Number is : {i} and cube of the {i} is :{cube}");
            }
            return default;
        }
    }
}

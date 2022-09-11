using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.For_Loop
{
    class Pr_10
    {
        public static string Solve(int n)
        {
            for (int i = 0; i != n; i++)
            {
                for (int j = 0; j != i; j++)
                {
                    Console.Write($"{j}");
                }
            }
            return default;
        }
    }
}

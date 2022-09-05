using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.For_Loop
{
    class Pr_6
    {
        public static string Solve(int n)
        {
            for(int i = 0; i != n; i++)
            {
                Console.WriteLine($"{n} X {i} = {i * n}");
            }

            return default;
        }
    }
}

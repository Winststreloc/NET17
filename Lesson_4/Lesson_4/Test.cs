using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Test
    {
        public static string Solve(int a)
        {
            int sum = 0;
            do
            {
                a /= 10;
                sum += a % 10;
            }
            while (a / 10 > 0);
            return $"Summ = {sum}";
        }
    }
}

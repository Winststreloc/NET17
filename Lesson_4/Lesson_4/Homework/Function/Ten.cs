using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.Function
{
    class Ten
    {
        public static string Solve(int a)
        {
            int sum = 0;
            do
            {
                sum += a % 10;
                Console.WriteLine(sum);
                a /= 10;
                Console.WriteLine(a);
            }
            while (a / 10 > 0);
            sum += a;
            return $"Summ = {sum}";
        }
    }
}

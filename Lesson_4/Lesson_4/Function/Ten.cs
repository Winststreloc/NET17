using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.Function
{
    class Ten
    {
        public static string Solve(int a)
        {
            object name;
            int sum = 0;
            while(a / 10 > 10)
            {
                sum += a % 10;
                a /= 10;
            }
            return $"Summ = {sum}";
        }
    }
}

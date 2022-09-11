using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem4
    {
        public static string Solve(int x)
        {
            if (x % 4 == 0)
            {
                if (x % 100 != 0 || x % 400 != 0)
                {
                    return $"{x} isn`t a leap year.";
                }
                return $"{x} is a leap year.";
            }

            else
            {
                return $"{x} isn`t a leap year.";
            }
        }
    }
}

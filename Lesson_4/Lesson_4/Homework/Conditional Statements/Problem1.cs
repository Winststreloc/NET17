using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem1
    {
        public static string Solve(int a, int b)
        {
            if (a == b)
            {
                return $"{a} and {b} are equal";
            }
            else
            {
                return $"{a} and {b} are not equal";
            }
        }
    }
}

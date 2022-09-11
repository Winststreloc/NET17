using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem2
    {
        public static string Solve(int x)
        {
            if (x % 2 == 0)
            {
                return $"{x} is an even integer";
            }
            else return $"{x} is an odd integer";
        }
    }
}

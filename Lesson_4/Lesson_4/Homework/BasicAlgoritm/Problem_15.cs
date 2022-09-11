using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem_15
    {
        public static bool Solve(int a, int b, int c)
        {
            return ((a >= 20 && a <= 50) || (b >= 20 && b <= 50) || (c >= 20 && c <= 50));
        }
    }
}

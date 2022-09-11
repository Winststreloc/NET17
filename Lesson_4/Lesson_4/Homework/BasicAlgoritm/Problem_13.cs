using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem_13
    {
        public static bool Solve(int a, int b)
        {
            return a < 0 && b > 100 || b < 0 && a > 100;
        }
    }
}

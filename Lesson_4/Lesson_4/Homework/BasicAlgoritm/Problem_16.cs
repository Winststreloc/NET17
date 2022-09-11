using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem_16
    {
        public static bool Solve(int a, int b)
        {
            return ((a <= 20 || b >= 50) || (a >= 50 || b <= 20));
        }
    }
}

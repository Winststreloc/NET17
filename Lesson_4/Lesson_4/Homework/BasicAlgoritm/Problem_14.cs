using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem_14
    {
        public static bool Solve(int a, int b)
        {
            if (a > 100 || b > 100 || a < 200 || b < 200)
            {
                return true;
            }
            else return false;
        }
    }
}

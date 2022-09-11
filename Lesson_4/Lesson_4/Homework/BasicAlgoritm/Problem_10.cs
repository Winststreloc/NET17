using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem_10
    {
        public static bool Solve(int x)
        {
            if (x % 3 == 0 || x % 7 == 0)
            {
                return true;
            }
            else return false;
        }
    }
}

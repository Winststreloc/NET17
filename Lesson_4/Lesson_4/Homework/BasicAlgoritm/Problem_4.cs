using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem_4
    {
        public static bool Solve(int a)
        {
            if (Math.Abs(a - 100) <= 10 || Math.Abs(a - 200) <= 10)
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem3
    {
        public static string Solve(int x)
        {
            return x >= 0 ? $"{x} is a positive number" : $"{x} is a negative number";
        }
    }
}

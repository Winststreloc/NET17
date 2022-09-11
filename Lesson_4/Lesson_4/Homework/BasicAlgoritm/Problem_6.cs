using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem_6
    {
        public static string Solve(string text, int x)
        {
            return text.Remove(x, x - 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem_5
    {
        public static string Solve(string text)
        {
            if (text.Contains("if"))
            {
                return text;
            }
            else
            {
                return "if " + text;
            }
        }
    }
}

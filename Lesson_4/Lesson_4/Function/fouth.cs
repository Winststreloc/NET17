using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.Function
{
    class Fouth
    {
        public static string Solve(string text)
        {
            int space = 0;
            for(int i = 0; i <= text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    space++;
                }
            }
            return $"{text} contains {space} spaces";
        }
    }
}

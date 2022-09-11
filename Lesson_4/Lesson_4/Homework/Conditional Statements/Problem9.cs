using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem9
    {
        public static string Solve(int x, int y)
        {
            if (x > 0)
            {
                if (y > 0)
                {
                    return "first quardinate";
                }
                else return "fourth quardinate";
            }
            else
            {
                if (y > 0)
                {
                    return "first quardinate";
                }
                else return "third quardinate";
            }
        }
    }
}

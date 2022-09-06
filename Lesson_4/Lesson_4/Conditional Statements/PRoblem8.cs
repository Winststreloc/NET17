using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class PRoblem8
    {
        public static string Solve(int x, int y, int z)
        {
            if(x > y && x > z)
            {
                return $"{x} is the greatest";
            }
            else if (y > z)
            {
                return $"{y} is the greatest";
            }
            else return $"{z} is the greatest";
        }
    }
}

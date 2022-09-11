using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem7
    {
        public static string Solve(float height)
        {
            if( height < 170.0)
            {
                return "Drawt";
            }
            else if (height >= 160.0 || height < 180.0)
            {
                return "Normal height";
            }
            else
            {
                return "Your taller";
            }
        }
    }
}

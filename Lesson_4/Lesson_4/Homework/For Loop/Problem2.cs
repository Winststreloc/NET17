using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.For_Loop
{
    class Problem2
    {
        public static int Solve()
        {
            int sum = 0;
            for(int i = 0; i != 10; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}

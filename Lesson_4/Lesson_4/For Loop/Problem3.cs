using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.For_Loop
{
    class Problem3
    {
        public static int Solve(int n)
        {
            int sum = 0;

            for (int i = 0; i != n; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            return sum;
        }
    }
}

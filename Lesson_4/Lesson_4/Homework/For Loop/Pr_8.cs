using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.For_Loop
{
    class Pr_8
    {
        public static int Solve(int n)
        {
            int odd = 1;
            int sum = 0;
            int[] num = new int[n];
            Console.WriteLine("The odd numbers are :");
            for (int i = 0; i != n; i++)
            {
                Console.Write(odd);
                num[i] = odd;
                odd += 2;
                sum += odd;
            }
            Console.WriteLine($"The Sum of odd Natural Number upto {n} terms : {sum}");
            return default;
        }
    }
}

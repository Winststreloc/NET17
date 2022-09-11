using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.For_Loop
{
    class Pr_4
    {
        public static string Solve()
        {
            int sum = 0;
            int[] number = new int[10];
            for(int i = 0; i != 10; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
                sum += number[i];
            }
            return $"sum = {sum} \n average = {sum / 10}";
        }
    }
}

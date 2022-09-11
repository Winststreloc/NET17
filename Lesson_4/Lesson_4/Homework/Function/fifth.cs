using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.Function
{
    class Fifth
    {
        public static string Solve()
        {
            int[] num = new int[5];
            int sum = 0;
           for(int i = 0; i != 5; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                sum += num[i];
            }
            return $"The sum of the elements of the array is {sum}";
        }
    }
}

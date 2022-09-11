using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.Function
{
    class Six
    {
        public static string Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return $"Now the 1st number is : {a} , and the 2nd number is : {b}";
        }
    }
}

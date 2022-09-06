using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.Function
{
    class Eighth
    {
        public static string Solve(int a)
        {
            int fibonachy = 0;
            int fibonachy2 = 1;
            for (int i = 0; i < a; i++)
            {
                Console.Write(fibonachy);
                fibonachy += fibonachy2;
                Console.Write(fibonachy2);
                fibonachy2 += fibonachy;
            }
            return default;
        }
    }
}

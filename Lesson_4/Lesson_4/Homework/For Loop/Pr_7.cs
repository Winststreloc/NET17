using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4.For_Loop
{
    class Pr_7
    {
        public static string Solve(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j <= n - 1)
                        Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                    else
                        Console.Write("{0}x{1} = {2}", j, i, i * j);

                }
            }

            return default;
        }	
    }
}

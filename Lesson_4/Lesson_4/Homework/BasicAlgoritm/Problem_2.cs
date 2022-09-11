using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem_2
    {
        const int fiftyone = 51;
        public static int Solve(int a)
        {
            if (a == fiftyone || a < fiftyone)
            {
                return Math.Abs((a - fiftyone) * 3);
            }
            else
            {
                return a - fiftyone;
            }
        }
    }
}

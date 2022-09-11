using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class Problem10
    {
        public static string Solve(int math, int phy, int chem)
        {
            if (math >= 65)
            {
                if (phy >= 55)
                {
                    if (chem >= 50)
                    {
                        if (math + phy + chem >= 180 || math + phy >= 140)
                        {
                            return " ok";
                        }
                        else
                        {
                            return "no";
                        }
                    }
                    else return "no";
                }
                else return "no";
            }

            else
            {
                return "no";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Samostoytelny
{
    public static class RAM
    {
        public static Dictionary<string, double> operations = new Dictionary<string, double>(5);

        public static void AllResult()
        {
            foreach (var res in operations)
            {
                Console.WriteLine($"Result: {res.Value} value: {res.Key}");
            }
        }
        public static string ChoiceUser(int a)
        {
            if (a > 0 && a <= 5)
            {
                int i = 0;
                foreach(var res in operations)
                {
                    i++;
                    if(i == a)
                    {
                        return res.Key;
                    }

                }
                throw new Exception("non contains");
            }
            else
            {
                throw new Exception("you choice is more 5 or less 0");
            }
        }
    }
}

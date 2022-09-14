using System;
using System.Collections.Generic;
using System.Text;

namespace Samostoytelny
{
    public static class RAM
    {
        public static List<string> exemple = new List<string>(5);
        public static List<double> result = new List<double>(5);

        public static void AddExample(string str, double res)
        {
            exemple.Add(str);
            result.Add(res);
        }
        public static void AllResult()
        {
            for(int i = 0; i < result.Count; i++)
            {
                Console.WriteLine($"{result[i]} = {exemple[i]}");
            }

            
        }
        public static string ChoiceUser(int a)
        {
            if (a > 0 && a <= 5)
            {
                return exemple[a-1];  
            }
            else
            {
                throw new Exception("you choice is more 5 or less 0");
            }
        }
    }
}

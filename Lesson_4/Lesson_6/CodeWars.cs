using System;


namespace Lesson_8
{
    public class CodeWars
    {
        public static bool IsPangram(string str)
        {
            string[] alphabet = new string[] { "a", "e", "i", "o", "u", "y", "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z"};
            str = str.ToLower();
            bool res = false;
            foreach(var s in alphabet)
            {
                if (str.Contains(s))
                {
                    res = true;
                    if (res == false) return false;
                }
            }
            return res;

        }
    }
}

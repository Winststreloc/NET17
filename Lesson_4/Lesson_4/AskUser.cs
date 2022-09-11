using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    class AskUser
    {
        public readonly static string[] parseAnswer = new string[] { "parse", "Parse", "p" };

        public static void Hello()
        {
            Console.WriteLine("Hello, everybody \n plus = +\n " +
                            "minus = -\n divider = /\n sqrt = sqrt\n " +
                            "remainder = остаток от деления \n percent = %");
        }
        public static bool AskParseOrSwitch()
        {
            Console.WriteLine("You need Parse or simply calculator?");

            if ("parse" == Console.ReadLine())
            {
                return true;
            }
            else return false;
        }
        public static bool AskIfContinue()
        {
            Console.WriteLine("Continue?");
            string answer = Console.ReadLine();
            return answer == "no";
        }

    }
}

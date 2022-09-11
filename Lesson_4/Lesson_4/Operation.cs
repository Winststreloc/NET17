using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lesson_4
{
    class Operation
    {
        public readonly static string[] allOperations = new string[] { "+", "-", "*", "/", "%", "rem" };


        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static double Minus(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b) {
            return a / b;
        }

        public static double Percent(double a, double b)
        {
            return a * (b / 100);
        }

        public static double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }

        public static double Remainder(double a, double b)
        {
            return a % b;
        }
        public static double Expression(string a)
        {

            string func = " ";
            a = a.Trim(' ');
            double result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    if (a.Contains(allOperations[i]))
                    {
                        func = allOperations[i];
                        string[] element = a.Split(func);
                        double temp = double.Parse(element[0]);
                        for (int j = 1; j < element.Length; j++)
                        {

                            temp = Program.CalculatorSwitch(func,
                                                            temp,
                                                            double.Parse(element[j]));
                        }
                        result += temp;

                    }
                    else if (a.Contains("sqrt"))
                    {
                        func = "sqrt";
                    }
                }
                catch
                {

                }



            }

            return result;
        }
    }

}

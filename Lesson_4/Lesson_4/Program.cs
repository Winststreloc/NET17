using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, everybody \n plus = +\n " +
                "minus = -\n / = /\n sqrt a or b= sqrt\n " +
                "remainder = остаток от деления \n percent = %");
            bool endApp = false;
            double result;


            while (!endApp)
            {
                Console.WriteLine("What is operation?");
                string operation = Console.ReadLine();

                Console.WriteLine("EnterNumeber");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());

                result = Calculator(a, b, operation);
                Console.WriteLine(result);

                endApp = Continue();
            }


        }

        
        public static double Calculator(double a, double b, string operation)
        {
            double number = 0;

            switch (operation)
            {
                case "plus":
                    number = a + b;
                    break;
                case "minus":
                    number = a - b;
                    break;
                case "/":
                    number = a / b;
                    break;
                case "percent":
                    number = a * (b / 100);
                    break;
                case "sqrt a":
                    number = Math.Sqrt(a);
                    break;
                case "sqrt b":
                    number = Math.Sqrt(b);
                    break;
                case "remainder":
                    number = a % b;
                    break;
                default:
                    number = default;
                    break;
            }

            return number;
        }

        static bool Continue()
        {
            Console.WriteLine("Continue?");
            string answer = Console.ReadLine();
            return answer == "no" ? true : false;
        }

    }
}

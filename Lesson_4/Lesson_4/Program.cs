using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
            StartApp();
        }
        public static void Hello()
        {
            Console.WriteLine("Hello, everybody \n plus = +\n " +
                "minus = -\n / = /\n sqrt a or b= sqrt\n " +
                "remainder = остаток от деления \n percent = %");
        }

        public static void StartApp()
        {
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
                    number = Plus(a,b);
                    break;
                case "minus":
                    number = Minus(a,b);
                    break;
                case "/":
                    number = Divide(a,b);
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
                    number = Remainder(a,b);
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

        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static double Minus(double a, double b)
        {
            return a - b;
        }
        public static double Divide(double a, double b)
        {
            return a + b;
        }

        public static double Percent(double a, double b)
        {
            return a * (b / 100);
        }

        public static double SqrtA(double a, double b)
        {
            return Math.Sqrt(a);
        }

        public static double SqrtB(double a, double b)
        {
            return Math.Sqrt(b);
        }

        public static double Remainder(double a, double b)
        {
            return a % b;
        }

    }
}

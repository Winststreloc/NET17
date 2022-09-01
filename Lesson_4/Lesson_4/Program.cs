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

            switch (operation)
            {
                case "plus":
                    return Plus(a,b);
                case "minus":
                    return Minus(a,b);
                case "/":
                    return Divide(a,b);
                case "percent":
                    return a * (b / 100);
                case "sqrt a":
                    return Math.Sqrt(a);
                case "sqrt b":
                    return Math.Sqrt(b);
                case "remainder":
                    return Remainder(a,b);
                default:
                    throw new Exception("404");
            }
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

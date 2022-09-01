using System;

namespace Lesson_4
{
    class Program
    {
        const string sqrtOper = "sqrt";
        const string plusOper = "plus";
        const string minusOper = "minus";
        const string divideOper = "/";
        const string remainderOper = "remainder";
        static void Main(string[] args)
        {
            Hello();
            StartApp();
        }
        public static void Hello()
        {
            Console.WriteLine("Hello, everybody \n plus = +\n " +
                "minus = -\n divider = /\n sqrt = sqrt\n " +
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
                if (operation != sqrtOper)
                {
                    double a = Convert.ToDouble(Console.ReadLine());
                    double b = Convert.ToDouble(Console.ReadLine());
                    result = Calculator(a, operation, b);
                }
                else 
                { 
                    double a = Convert.ToDouble(Console.ReadLine());
                    result = Calculator(a, operation);
                }
                Console.WriteLine(result);

                endApp = AskIfContinue();
            }
        }
        
        public static double Calculator(double a, string operation, double b = default)
        {

            switch (operation)
            {
                case plusOper:
                    return Plus(a,b);
                case minusOper:
                    return Minus(a,b);
                case divideOper:
                    return Divide(a,b);
                case "percent":
                    return a * (b / 100);
                case sqrtOper:
                    return Math.Sqrt(a);
                case remainderOper:
                    return Remainder(a,b);
                default:
                    throw new Exception("404");
            }
        }

        static bool AskIfContinue()
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

        public static double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }

        public static double Remainder(double a, double b)
        {
            return a % b;
        }

    }
}

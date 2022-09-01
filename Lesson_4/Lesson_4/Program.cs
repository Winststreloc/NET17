using System;

namespace Lesson_4
{
    class Program
    {
        //const
        const string sqrtOper = "sqrt";
        const string plusOper = "plus";
        const string minusOper = "minus";
        const string divideOper = "/";
        const string remainderOper = "remainder";
        const string percentOper = "percent";



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

                result = NeedTwoOperator(operation);
                Console.WriteLine(result);

                endApp = AskIfContinue();
            }
        }
        static double NeedTwoOperator(string operation)
        {
            Console.WriteLine("EnterNumeber");

            if (operation != sqrtOper)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                return Calculator(a, operation, b);
            }
            else
            {
                double a = Convert.ToDouble(Console.ReadLine());
                return Calculator(a, operation);
            }
        }
        static bool AskIfContinue()
        {
            Console.WriteLine("Continue?");
            string answer = Console.ReadLine();
            return answer == "no" ? true : false;
        }

        public static double Calculator(double a, string operation, double b = default)
        {

            switch (operation)
            {
                case plusOper:
                    return Operation.Plus(a,b);
                case minusOper:
                    return Operation.Minus(a,b);
                case divideOper:
                    return Operation.Divide(a,b);
                case percentOper:
                    return Operation.Percent(a, b);
                case sqrtOper:
                    return Operation.Sqrt(a);
                case remainderOper:
                    return Operation.Remainder(a,b);
                default:
                    throw new Exception("404");
            }
        }

        

    }
}

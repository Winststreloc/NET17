using System;
using System.Linq;


namespace Lesson_4
{
    class Program
    {
        public readonly static string[] allOperations = new string[] { "+", "-", "*", "/", "%", "rem" };
        

        static void Main(string[] args)
        {
            AskUser.Hello();
            StartApp();
        }

        public static void StartApp()
        {
            bool endApp = false;
            double result;

            while (!endApp)
            {
                bool parse = AskUser.AskParseOrSwitch();
                if (parse)
                {

                    try
                    {
                        result = CalculatorExpression();
                        Console.WriteLine(result);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        StartApp();
                    }

                }
                else
                {
                    Console.WriteLine("What is operation?");
                    result = NeedTwoOperator(Console.ReadLine());
                    Console.WriteLine(result);
                }
                endApp = AskUser.AskIfContinue();
            }
        }

        static double NeedTwoOperator(string operation)
        {
            Console.WriteLine("EnterNumeber");
            if (operation != "sqrt")
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                return CalculatorSwitch(operation, a, b);
            }
            else
            {
                double a = Convert.ToDouble(Console.ReadLine());
                return CalculatorSwitch(operation, a);
            }
        }

        public static double CalculatorSwitch(string operation, double a, double b = default)
        {

            return operation switch
            {
                "+" => Operation.Plus(a, b),
                "-" => Operation.Minus(a, b),
                "*" => Operation.Multiply(a, b),
                "/" => Operation.Divide(a, b),
                "%" => Operation.Percent(a, b),
                "sqrt" => Operation.Sqrt(a),
                "rem" => Operation.Remainder(a, b),
                _ => throw new Exception("404"),
            };
        }

        public static double CalculatorExpression()
        {
            string str = Console.ReadLine();
            return Operation.Expression(str);
        }
    }
}

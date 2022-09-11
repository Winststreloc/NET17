using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Samostoytelny
{
    public class Parse
    {
        public const char END_LINE = '\n';
        public static Stack<string> operand = new Stack<string>();
        public static Stack<double> number = new Stack<double>();
        public static string regSqrt = @"(sqrt)(\d+)";
        public static double Solve(string str)
        {
            str = str.Trim(' ');
            string tempStr = str;
            ReplaceSqrtInStr(str);
            double result = FillStack(str);
            RAM.operations.Add(result, tempStr);
            return result;
        }

        static int GetPriority(string action)
        {
            switch (action)
            {
                case "sqrt":
                case "^": return 3;
                case "*":
                case "/": return 2;
                case "+":
                case "-": return 1;
            }
            return 0;
        }
        static string ReplaceSqrtInStr(string str)
        {

            if (!Regex.IsMatch(str, regSqrt))
            {
                return str;
            }
            else
            {
                Match temp = Regex.Match(str, regSqrt);
                string text = temp.ToString();
                text = text.Substring(4);

                str = Regex.Replace(str, regSqrt, $"{ Operation.Sqrt(double.Parse(text))}");
                return str;
            }
            
        }

        static double FillStack(string str)
        {
            foreach (var s in str)
            {
                if (double.TryParse(s.ToString(), out double num))
                {
                    number.Push(num);
                }
                else
                {
                    try
                    {
                        if (GetPriority(s.ToString()) <= GetPriority(operand.Peek()))
                        {
                            PopStack();
                        }
                    }
                    catch
                    {
                        
                    }
                    
                    operand.Push(s.ToString());
                }
            }
            while(operand.Count >= 1)
            {
                PopStack();
            }
            return number.Pop();
        }
        public static void PopStack()
        {
            try
            {
                double temp1 = number.Pop();
                double temp2 = number.Pop();
                double temp = CalculatorSwitch(operand.Pop(), temp2, temp1);
                number.Push(temp);
            }
            catch (Exception ex)
            {
                Console.WriteLine("noname exception", ex.Message);
            }
        }

        public static double CalculatorSwitch(string operation, double a, double b)
        {

            return operation switch
            {
                "+" => Operation.Plus(a, b),
                "-" => Operation.Minus(a, b),
                "*" => Operation.Multiply(a, b),
                "/" => Operation.Divide(a, b),
                "sqrt"=> Operation.Sqrt(a),
                "^" => Operation.Pow(a, b),
                _ => throw new Exception("operation non supported"),
            };
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Samostoytelny
{
    public class Parse
    {
        public static Stack<string> operand = new Stack<string>();
        public static Stack<double> number = new Stack<double>();


        public static double Solve(string str)
        {
            str = PreProcess(str);
            double result = FillStack(str);
            try
            {
                RAM.AddExample(str, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        public static string PreProcess(string str)
        {
            str = str.Trim(' ');
            ReplaceSqrtInStr(str);
            str = str.Replace("-(", "-1*(");
            str = str.Replace("--", "+");
            str = str.Replace(",", ".");

            return str;
        }

        static int GetPriority(string action)
        {
            switch (action)
            {
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

            if (!Regex.IsMatch(str, Constant.regSqrt))
            {
                return str;
            }
            else
            {
                Match temp = Regex.Match(str, Constant.regSqrt);
                string text = temp.ToString();
                text = text[Constant.sqrt..];

                str = Regex.Replace(str, Constant.regSqrt, $"{ Operation.Sqrt(double.Parse(text))}");
                return str;
            }

        }
        static void IfNumber(string str, int i)
        {
            string temp = default;
            bool endApp = true;
            while (endApp)
            {
                if (i < str.Length)
                {
                    if ((double.TryParse(str[i].ToString(), out double num)) || str[i].ToString() == ".")
                    {
                        if (str[i].ToString() == ".")
                        {
                            temp += ",";
                        }
                        else temp += $"{num}";
                        i++;
                    }
                    else
                    {
                        i--;
                        endApp = false;
                    }
                }
                else
                {
                    endApp = false;
                }


            }
            number.Push(double.Parse(temp, System.Globalization.NumberStyles.AllowDecimalPoint));
        }
        static void IfOperandPush(string str, int i)
        {
            try
            {
                if (GetPriority(str[i].ToString()) <= GetPriority(operand.Peek()))
                {
                    PopStack();
                }
            }
            catch
            {

            }

            operand.Push(str[i].ToString());
        }
        static void IfBracket()
        {
            while (operand.Peek() != "(")
            {
                PopStack();
            }
            operand.Pop();
        }

        static double FillStack(string str)
        {
            for (int i = 0; i < str.Length; i++)
            { 
                if (!double.TryParse(str[i].ToString(), out _))
                {

                        if(str[i].ToString() == ")")
                        {
                            IfBracket();
                        }
                        else
                        {
                            IfOperandPush(str, i);
                        }

                }
                else
                {
                    IfNumber(str, i);
                }
            }

            while (operand.Count >= 1)
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
                double temp = Operation.CalculatorSwitch(operand.Pop(), temp2, temp1);
                number.Push(temp);
            }
            catch
            {
                Console.WriteLine("You confised me\n" +
                    "Enter new example");
                Program.StartApp();

            }

        }
    }   
}


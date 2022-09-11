using System;

namespace TryToWin
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Rework.Eval("5+2-3"));
        }
    }

    public class Rework
    {
        public static double Eval(string str)
        {

                int pos = -1, ch;

                void nextChar()
                {
                    ch = (++pos < str.Length) ? str[pos] : -1;
                }

                bool eat(int charToEat)
                {
                    while (ch == ' ') nextChar();
                    if (ch == charToEat)
                    {
                        nextChar();
                        return true;
                    }
                    return false;
                }

                double Parse()
                {
                    nextChar();
                    double x = ParseExpression();
                    if (pos < str.Length) throw new Exception("Unexpected: " + (char)ch);
                    return x;
                }

                double ParseExpression()
                {
                    double x = ParseTerm();
                    for (; ; )
                    {
                        if (eat('+')) x += ParseTerm(); // addition
                        else if (eat('-')) x -= ParseTerm(); // subtraction
                        else return x;
                    }
                }

                double ParseTerm()
                {
                    double x = ParseFactor();
                    for (; ; )
                    {
                        if (eat('*')) x *= ParseFactor(); // multiplication
                        else if (eat('/')) x /= ParseFactor(); // division
                        else return x;
                    }
                }

                double ParseFactor()
                {
                    if (eat('+')) return ParseFactor(); // unary plus
                    if (eat('-')) return -ParseFactor(); // unary minus

                    double x;
                    int startPos = pos;
                    if (eat('('))
                    { // parentheses
                        x = ParseExpression();
                        eat(')');
                    }
                    else if ((ch >= '0' && ch <= '9') || ch == '.')
                    { // numbers
                        while ((ch >= '0' && ch <= '9') || ch == '.') nextChar();
                        x = double.Parse(str.Substring(startPos, pos));
                    }
                    else
                    {
                        throw new Exception("Unexpected: " + (char)ch);
                    }

                    if (eat('^')) x = Math.Pow(x, ParseFactor()); // exponentiation

                    return x;
                }

            return Parse();
        
        }
        
    }    
}


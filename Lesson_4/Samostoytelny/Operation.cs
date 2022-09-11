using System;
using System.Collections.Generic;
using System.Text;

namespace Samostoytelny
{
    public class Operation
    {
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
        public static double Divide(double a, double b)
        {
            return a / b;
        }
        public static double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }
        public static double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}

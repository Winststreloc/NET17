using System;
using System.Collections.Generic;
using System.Text;

namespace LEsson8
{
    public class Printer
        
    {
        public Printer()
        {
        }
        public void Print(Shape shape, int size, string oper)
        {
            shape.Print(size, oper, shape.Line, shape.Column);
        }
    }
    interface IPrinteble
    {
        void PrintText(string text, int line, int column);
    }
}

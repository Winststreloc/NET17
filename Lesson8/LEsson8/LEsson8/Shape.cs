using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Text;

namespace Lesson8
{
    public abstract class Shape : IPrintable
    {
        protected int Size { get; }
        protected string Oper { get; }
        protected int Line { get; }
        protected int Column { get; }
        public Shape(int size, string oper, int line, int column)
        {
            Size = size;
            Oper = oper;
            Line = line;
            Column = column;
        }
        public abstract void Print(int size, string oper, int line, int column);
    }

}

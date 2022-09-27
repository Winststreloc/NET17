using System;
using System.Collections.Generic;
using System.Text;

namespace LEsson8
{
    public abstract class Shape
    {
        public int Column { get; set; }
        public int Line { get; set; }
        public abstract void Print(int size, string oper, int line, int column);

    }
}

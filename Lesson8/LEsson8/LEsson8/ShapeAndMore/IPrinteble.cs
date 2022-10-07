using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8.ShapeAndMore
{
    public interface IPrintable
    {
        void Print(int size, string oper, int line, int column);
        void Print(string text, int line, int column);
    }
}

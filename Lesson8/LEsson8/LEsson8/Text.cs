using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace LEsson8
{
    class Text: IPrinteble
    {
        public int Column { get; set; }
        public int Line { get; set; }
        public Text(int line, int column)
        {
            Column = column;
            Line = line;
        }
        public void PrintText(string text, int line, int column)
        {
            Console.SetCursorPosition(column, line);
            Console.Write(text);
        }
    }
}

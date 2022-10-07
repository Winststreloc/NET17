using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8.Printer
{
    public class ConsolePrinter : IPrinter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void SetCursor(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
    }

}

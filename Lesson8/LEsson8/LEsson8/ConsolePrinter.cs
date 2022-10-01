using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{
    public class ConsolePrinter : IPrinter
    {
        public IPrinter.ConsolePrint print = (text) => Console.Write(text);
        public IPrinter.ConsolePrint printLine = (text) => Console.Write(text);
        public IPrinter.ConsoleSetCursor SetCursor = (x , y) => Console.SetCursorPosition(x, y);
        public ConsolePrinter()
        {

        }
    }
}

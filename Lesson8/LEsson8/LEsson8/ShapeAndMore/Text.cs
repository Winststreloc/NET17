using Lesson8.Printer;
using System;

namespace Lesson8.ShapeAndMore
{
    [ColorPrint(ConsoleColor.Red)]
    public class Text : IPrintable
    {
        public string Word { get; set; }
        public int Column { get; set; }
        public int Line { get; set; }
        FilePrinter printer = new FilePrinter();
        public Text(string text, int column, int line)
        {
            Word = text;
            Column = column;
            Line = line;
        }
        public void Print(string text, int column, int line)
        {
            printer.SetCursor(column, line);
            printer.Write(text);
        }

        public void Print(int size, string oper, int line, int column)
        {
            throw new NotImplementedException();
        }
    }
}

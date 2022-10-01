using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Lesson8.ShapeAndMore
{
    [ColorPrint(ConsoleColor.Red)]
    public class Text : IPrintable
    {
        public string Word { get; set; }
        public int Column { get; set; }
        public int Line { get; set; }
        ConsolePrinter printer = new ConsolePrinter();
        public Text(string text, int column, int line)
        {
            Word = text;
            Column = column;
            Line = line;
        }
        public void Print(string text, int column, int line)
        {
            ColorPrintAttribute MyAttribute =
                (ColorPrintAttribute)Attribute.GetCustomAttribute(typeof(Triangle), typeof(ColorPrintAttribute));
            System.ConsoleColor cvet = (System.ConsoleColor)MyAttribute.ColorFig;
            Console.ForegroundColor = cvet; //SETCOLOR

            printer.SetCursor(column, line);
            printer.print(text);

            Console.ResetColor(); //RESETCOLOR
        }

        public void Print(int size, string oper, int line, int column)
        {
            throw new NotImplementedException();
        }
    }
}

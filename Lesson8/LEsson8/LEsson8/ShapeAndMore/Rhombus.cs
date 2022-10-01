using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Lesson8.ShapeAndMore
{
    [ColorPrint(ConsoleColor.Blue)]
    public class Rhombus : Shape
    {
        ConsolePrinter printer = new ConsolePrinter();
        public Rhombus(int size, string oper, int line, int column) : base(size, oper, line, column)
        {

        }
        public override void Print(int size, string oper, int line, int column)
        {
            ColorPrintAttribute MyAttribute =
    (ColorPrintAttribute)Attribute.GetCustomAttribute(typeof(Triangle), typeof(ColorPrintAttribute));
            System.ConsoleColor cvet = (System.ConsoleColor)MyAttribute.ColorFig;
            Console.ForegroundColor = cvet; // устанавливаем цвет

            for (int y = 1; y < size * 2; ++y, line++)
            {
                try
                {
                    printer.SetCursor(column - y, line);
                    printer.print(oper);
                    printer.SetCursor(column + y, line);
                    printer.print(oper);
                }
                catch
                {
                    printer.SetCursor(0, line);
                    printer.print("Error in this line!!!!!!");
                }


            }
            printer.SetCursor(column, line - size);
            printer.print(oper);
            for (int y = size * 2; y != 0; --y, line++)
            {
                try
                {
                    printer.SetCursor(column - y, line);
                    printer.print(oper);
                    printer.SetCursor(column + y, line);
                    printer.print(oper);
                }
                catch
                {
                    printer.SetCursor(0, line);
                    printer.print("Error in this line!!!!!!");
                }

            }
            printer.SetCursor(column, line);
            printer.print(oper);
        }
    }
}

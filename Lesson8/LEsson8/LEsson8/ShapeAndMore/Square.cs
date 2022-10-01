using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8.ShapeAndMore
{
    [ColorPrint(ConsoleColor.Red)]
    class Square : Shape
    {
        ConsolePrinter printer = new ConsolePrinter();

        public Square(int size, string oper, int line, int column) : base(size, oper, line, column)
        {

        }
        public override void Print(int size, string oper, int line, int column)
        {
            ColorPrintAttribute MyAttribute =
                (ColorPrintAttribute)Attribute.GetCustomAttribute(typeof(Triangle), typeof(ColorPrintAttribute));
            System.ConsoleColor cvet = (System.ConsoleColor)MyAttribute.ColorFig;
            Console.ForegroundColor = cvet; //COLOR

            printer.SetCursor(line, column);
            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    printer.print(oper);
                }
                printer.SetCursor(line, column++);
            }

            Console.ResetColor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lesson8.ShapeAndMore
{

    [ColorPrint(ConsoleColor.Blue)]
    public class Triangle : Shape
    {
        ConsolePrinter printer = new ConsolePrinter();
        public Triangle(int size, string oper, int line, int column) : base(size, oper, line, column)
        {

        }
        public override void Print(int size, string oper, int line, int column)
        {
            ColorPrintAttribute MyAttribute =
            (ColorPrintAttribute)Attribute.GetCustomAttribute(typeof(Triangle), typeof(ColorPrintAttribute));
            System.ConsoleColor cvet = (System.ConsoleColor)MyAttribute.ColorFig;
            Console.ForegroundColor = cvet; //COLOR

            printer.SetCursor(0, line);
            for (int i = size; i != 0; i--)
            {
                for (int j = column; j != 0; j--)
                {
                    printer.print(" ");
                }
                printer.print(oper);
                for (int m = (size - i) * 2; m != 0; m--)
                    printer.print(oper);
                printer.print("\n");
                column--;
            }


            Console.ResetColor(); // ENDCOLOR
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Lesson8.Printer;

namespace Lesson8.ShapeAndMore
{

    [ColorPrint(ConsoleColor.Blue)]
    public class Triangle : Shape
    {
        public Triangle(int size, string oper, int line, int column) : base(size, oper, line, column)
        {

        }
        public override void Print(int size, string oper, int line, int column)
        {
            var printer = CallPrinter();

            printer.SetCursor(0, line);
            for (int i = size; i != 0; i--)
            {
                for (int j = column; j != 0; j--)
                {
                    printer.Write(" ");
                }
                printer.Write(oper);
                for (int m = (size - i) * 2; m != 0; m--)
                    printer.Write(oper);
                printer.Write("\n");
                column--;
            }

        }

        public IPrinter CallPrinter()
        {
            Console.WriteLine("You want write in the file?");
            if (Console.ReadLine() == "Yes")
            {
                IPrinter filePrinter = new FilePrinter();
                return filePrinter;
            }

            IPrinter conPrinter = new ConsolePrinter();
            return conPrinter;
        }

    }
}

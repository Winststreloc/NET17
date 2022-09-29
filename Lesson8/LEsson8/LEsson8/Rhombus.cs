using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{
    public class Rhombus : Shape
    {
        public Rhombus(int size, string oper, int line, int column) : base(size, oper, line, column)
        {

        }
        public override void Print(int size, string oper, int line, int column)
        {
            for (int y = 1; y < size * 2; ++y, line++)
            {
                try
                {
                    Console.SetCursorPosition(column - y, line);
                    Console.Write(oper);
                    Console.SetCursorPosition(column + y, line);
                    Console.Write(oper);
                }
                catch
                {
                    Console.SetCursorPosition(0, line);
                    Console.Write("Error in this line!!!!!!");
                }


            }
            Console.SetCursorPosition(column, line - size);
            Console.Write(oper);
            for (int y = size * 2; y != 0; --y, line++)
            {
                try
                {
                    Console.SetCursorPosition(column - y, line);
                    Console.Write(oper);
                    Console.SetCursorPosition(column + y, line);
                    Console.Write(oper);
                }
                catch
                {
                    Console.SetCursorPosition(0, line);
                    Console.Write("Error in this line!!!!!!");
                }

            }
            Console.SetCursorPosition(column, line);
            Console.Write(oper);
        }
    }
}

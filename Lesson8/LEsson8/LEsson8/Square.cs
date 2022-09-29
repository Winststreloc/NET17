using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{
    class Square : Shape
    {
        public Square(int size, string oper, int line, int column) : base(size, oper, line, column)
        {

        }
        public override void Print(int size, string oper, int line, int column)
        {
            Console.SetCursorPosition(line, column);
            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(oper);
                }
                Console.SetCursorPosition(line, column++);
            }
        }
    }
}

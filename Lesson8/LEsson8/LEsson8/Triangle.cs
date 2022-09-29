﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{
    public class Triangle : Shape
    {
        public Triangle(int size, string oper, int line, int column) : base(size, oper, line, column)
        {

        }
        public override void Print(int size, string oper, int line, int column)
        {
            Console.SetCursorPosition(0, line);
            for (int i = size; i != 0; i--)
            {
                for (int j = column; j != 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write(oper);
                for (int m = (size - i) * 2; m != 0; m--)
                    Console.Write(oper);
                Console.Write("\n");
                column--;
            }
        }
    }
}

using System;
using Lesson8.ShapeAndMore;

namespace Lesson8
{
    public class ColorPrintAttribute : Attribute
    {
        public ConsoleColor ColorFig { get; set; }
        public ColorPrintAttribute(ConsoleColor color)
        {
            ColorFig = color;
        }

    }
    public enum ConsoleColor { Red, Blue, Green }
}

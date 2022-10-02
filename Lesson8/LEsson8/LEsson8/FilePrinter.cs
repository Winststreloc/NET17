using System;
using System.IO;

namespace Lesson8
{
    public class FilePrinter : IPrinter
    {
        ConsolePrinter printer = new ConsolePrinter();
        public IPrinter.ConsoleSetCursor SetCursor = (x, y) => Console.SetCursorPosition(x, y);
        public static string path = @"D:\Study\NET17\Lesson8\LEsson8\LEsson8\temp.txt";
        public void Print(string text)
        {
            printer.print(text);
            using StreamWriter writer = new StreamWriter(path, true);
            writer.Write(text);

        }
    }
}

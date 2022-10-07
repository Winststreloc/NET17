using System;
using System.IO;

namespace Lesson8.Printer
{
    public class FilePrinter : IPrinter
    {
        private readonly ConsolePrinter _printer = new ConsolePrinter();
        public static string path = @"D:\Study\NET17\Lesson8\LEsson8\LEsson8\temp.txt";
        public void Write(string text)
        {
            _printer.Write(text);
            using StreamWriter writer = new StreamWriter(path, true);
            writer.Write(text);

        }
        public void WriteLine(string text)
        {
            _printer.WriteLine(text);
            using StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(text);

        }

        public void SetCursor(int x, int y)
        {
            _printer.SetCursor(x, y);
        }
    }
}

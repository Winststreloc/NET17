using Lesson8.FileMAnager;
using Lesson8.Printer;
using Lesson8.ShapeAndMore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Lesson8
{

    public class UiStartApp
    {
        private static readonly ConsolePrinter Printer = new ConsolePrinter();
        private static readonly Drawer drawer = new Drawer();
        private static readonly History history = new History();
        public static void Start()
        {
            Drawer.AddElementInHistory += history.Add;

            Printer.WriteLine("You want work with file? "); 
            UIFileManager.NeedStart(Console.ReadLine());

            drawer.Drawing();
            history.PrintAllFigure();
        }
    }
}

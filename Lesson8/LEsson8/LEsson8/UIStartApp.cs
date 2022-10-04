using Lesson8.ShapeAndMore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Lesson8
{

    public class UiStartApp
    {
        public static event Action EventEndApp;
        private static readonly ConsolePrinter Printer = new ConsolePrinter();
        private static readonly Assembly Asmbly = Assembly.GetExecutingAssembly();
        private static readonly List<Type> TypeList = Asmbly.GetTypes().Where(
                t => t.GetInterface("IPrintable") != null).ToList();

        public void Start()
        {
            EventEndApp += Start;
            Printer.printLine("You want work with file?\n");
            UIFileManager.NeedStart(Console.ReadLine());

            Drawing();

            Printer.printLine("You want continue?");
            if (Console.ReadLine() == "Yes")
            {
                DeleteAllString();   
                EndApp();
            }
        }
        public static void Drawing()
        {
            Type type = typeof(IPrintable);
            Type[] types = Assembly.GetAssembly(type)?.GetTypes();

            PrintAllFigure();
            string figure = EnterFigure();
            object[] param = EnterParam(figure);

            if (types != null)
                foreach (var item in types)
                {
                    if (item.Name == figure)
                    {
                        if (figure != "Text")
                        {
                            var obj = (IPrintable)Activator.CreateInstance(item, param);
                            obj?.Print((int)param[0], (string)param[1], (int)param[2], (int)param[3]);
                        }
                        else
                        {
                            var obj = (IPrintable)Activator.CreateInstance(item, param);
                            obj?.Print((string)param[0], (int)param[1], (int)param[2]);
                        }
                    }
                }
        }
        protected virtual void EndApp()
        {
            EventEndApp?.Invoke();
        }
        public static object[] EnterParam(string figure)
        {
            object[] param;
            if (figure == "Text" || figure == "text")
            {
                Printer.print("Enter text: ");
                string text = Console.ReadLine();
                DeleteString();
                Printer.print("Enter x: ");
                int x = int.Parse(Console.ReadLine() ?? "0");
                DeleteString();
                Printer.print("Enter y: ");
                int y = int.Parse(Console.ReadLine() ?? "0");
                DeleteString();
                param = new object[] { text, x, y };
            }
            else
            {
                Printer.print("Enter size: ");
                int size = int.Parse(Console.ReadLine() ?? "5");
                DeleteString();
                Printer.print("Enter operator: ");
                string @operator = Console.ReadLine();
                DeleteString();
                Printer.print("Enter x: ");
                int x = int.Parse(Console.ReadLine() ?? "0");
                DeleteString();
                Printer.print("Enter y: ");
                int y = int.Parse(Console.ReadLine() ?? "0");
                DeleteString();
                param = new object[] { size, @operator, x, y };
            }
            return param;
        }
        public static string EnterFigure()
        {
            Printer.print("Enter you figure: ");
            string figure = Console.ReadLine();
            DeleteString();
            return figure;
        }

        public static void DeleteString()
        {
            Console.SetCursorPosition(0, 1);
            Console.Write("                                                         ");
            Console.SetCursorPosition(0, 1);
        }
        public static void DeleteAllString()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("                                                                      ");
            Console.SetCursorPosition(0, 1);
            Console.Write("                                                                      ");
            Console.SetCursorPosition(0, 0);
        }
        public static void PrintAllFigure()
        {
            Printer.print("All figure: ");
            foreach (var shape in TypeList)
            {
                if (shape.Name != "Shape" && shape.Name != "Printer")
                {
                    Console.Write($"{shape.Name} ");

                }

            }
            Printer.print(" ");

        }

    }
}

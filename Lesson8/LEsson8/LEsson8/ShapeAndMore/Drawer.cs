using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Lesson8.Printer;
using static System.DateTime;

namespace Lesson8.ShapeAndMore
{
    public class Drawer
    {
        public static event Action<Shape> AddElementInHistory;

        private static readonly ConsolePrinter Printer = new ConsolePrinter();

        private static readonly Assembly Asmbly = Assembly.GetExecutingAssembly();
        private static readonly List<Type> TypeList = Asmbly.GetTypes().Where(
            t => t.GetInterface("IPrintable") != null).ToList();

        public void Drawing()
        {
             
            Type type = typeof(IPrintable);
            Type[] types = Assembly.GetAssembly(type)?.GetTypes();

            PrintAllFigure();
            string figure = EnterFigure();
            object[] param = EnterParam(figure);

            if (types != null)
            {
                foreach (var item in types)
                {
                    if (item.Name == figure)
                    {
                        if (figure != "Text")
                        {
                            var obj = (Shape)Activator.CreateInstance(item, param);
                            obj?.Print((int)param[0], (string)param[1], (int)param[2], (int)param[3]);
                            AddElementInHistory?.Invoke(obj);
                        }
                        else
                        {
                            var obj = (Shape)Activator.CreateInstance(item, param);
                            obj?.Print((string)param[0], (int)param[1], (int)param[2]);
                            AddElementInHistory?.Invoke(obj);
                        }
                    }
                }
            }
            EndApp();
        }
        protected virtual void EndApp()
        {
            Drawer.DeleteAllString();
            Printer.Write("You want continue");
            if (Console.ReadLine() == "Yes")
            {
                Drawer.DeleteAllString();
                Drawing();
            }
        }

        /// <summary>
        /// Other operation for menu
        /// </summary>
        public static object[] EnterParam(string figure)
        {
            object[] param;
            if (figure == "Text" || figure == "text")
            {
                Printer.Write("Enter text: ");
                string text = Console.ReadLine();
                DeleteString();
                Printer.Write("Enter x: ");
                int x = int.Parse(Console.ReadLine() ?? "0");
                DeleteString();
                Printer.Write("Enter y: ");
                int y = int.Parse(Console.ReadLine() ?? "0");
                DeleteString();
                param = new object[] { text, x, y };
            }
            else
            {
                Printer.Write("Enter size: ");
                int size = int.Parse(Console.ReadLine() ?? "5");
                DeleteString();
                Printer.Write("Enter operator: ");
                string @operator = Console.ReadLine();
                DeleteString();
                Printer.Write("Enter x: ");
                int x = int.Parse(Console.ReadLine() ?? "0");
                DeleteString();
                Printer.Write("Enter y: ");
                int y = int.Parse(Console.ReadLine() ?? "0");
                DeleteString();
                param = new object[] { size, @operator, x, y };
            }
            return param;
        }
        public static string EnterFigure()
        {
            Printer.Write("Enter you figure: ");
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
            Printer.Write("All figure: ");
            foreach (var shape in TypeList)
            {
                if (shape.Name != "Shape" && shape.Name != "Printer")
                {
                    Console.Write($"{shape.Name} ");
                }
            }
            Printer.Write(" ");
        }
    }
}

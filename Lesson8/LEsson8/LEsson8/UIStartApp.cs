using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using System.Linq;
using System.Drawing;
using Lesson8.ShapeAndMore;
using System.IO;

namespace Lesson8
{
    public class UIStartApp
    {
        private static readonly Assembly asmbly = Assembly.GetExecutingAssembly();
        private static readonly List<Type> typeList = asmbly.GetTypes().Where(
                t => t.GetInterface("IPrintable") != null).ToList();

        public static void Start()
        {
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("./Redirect.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Type type = typeof(IPrintable);
            Type[] types = Assembly.GetAssembly(type)?.GetTypes();

            PrintAllFigure();

            string figure = EnterFigure();
            object[] param = EnterParam(figure);

            foreach (var item in types)
            {
                if (item.Name == figure)
                {
                    if (figure != "Text")
                    {
                        var obj = (IPrintable)Activator.CreateInstance(item, param);
                        obj.Print((int)param[0], (string)param[1], (int)param[2], (int)param[3]);
                    }
                    else
                    {
                        var obj = (IPrintable)Activator.CreateInstance(item, param);
                        obj.Print((string)param[0], (int)param[1], (int)param[2]);
                    }
                }
            }
            DeleteAllString();

            TaskCompleted completed = EndApp;
            UIDelegat endapp = new UIDelegat();
            endapp.ContinueWork(completed);
            writer.Close();
        }
        public static void EndApp(string endApp)
        {
            Console.Write("You want continue?");

        }
        public static object[] EnterParam(string figure)
        {
            object[] param;
            if (figure == "Text" || figure == "text")
            {
                Console.Write("Enter text: ");
                string text = Console.ReadLine();
                DeleteString();
                Console.Write("Enter x: ");
                int x = int.Parse(Console.ReadLine());
                DeleteString();
                Console.Write("Enter y: ");
                int y = int.Parse(Console.ReadLine());
                DeleteString();
                param = new object[] { text, x, y };
            }
            else
            {
                Console.Write("Enter size: ");
                int size = int.Parse(Console.ReadLine());
                DeleteString();
                Console.Write("Enter operator: ");
                string oper = Console.ReadLine();
                DeleteString();
                Console.Write("Enter x: ");
                int x = int.Parse(Console.ReadLine());
                DeleteString();
                Console.Write("Enter y: ");
                int y = int.Parse(Console.ReadLine());
                DeleteString();
                param = new object[] { size, oper, x, y };
            }
            return param;
        }
        public static string EnterFigure()
        {
            Console.Write("Enter you figure: ");
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
            Console.Write("                                                         ");
            Console.SetCursorPosition(0, 1);
            Console.Write("                                                         ");
            Console.SetCursorPosition(0, 0);
        }
        public static void PrintAllFigure()
        {
            Console.Write("All figure: ");
            foreach (var shape in typeList)
            {
                if (shape.Name == "Shape" || shape.Name == "Printer")
                {
                    continue;
                }
                else
                {
                    Console.Write($"{shape.Name} ");
                }

            }
            Console.WriteLine(" ");
        }

    }
}

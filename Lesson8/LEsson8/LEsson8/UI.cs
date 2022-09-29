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


namespace Lesson8
{
    public class UI
    {
        private static readonly Assembly asmbly = Assembly.GetExecutingAssembly();
        private static readonly List<Type> typeList = asmbly.GetTypes().Where(
                t => t.GetInterface("IPrintable") != null).ToList();


        public static void Start()
        {
            Type type = typeof(IPrintable);
            Type[] types = Assembly.GetAssembly(type)?.GetTypes();
            bool endApp = false;
            while (!endApp)
            {
                WriteLine("Enter figure or word, znak / {skip}, size / {skip}, x, y");
                PrintAllFigure();

                string figure = EnterFigure();
                object[] param = EnterParam(figure);


                foreach (var item in types)
                {
                    if (item.Name == figure)
                    {
                        var obj = (IPrintable)Activator.CreateInstance(item, param);
                        obj.Print((int)param[0], (string)param[1], (int)param[2], (int)param[3]);
                    }
                }
                endApp = true;

            }
        }
        public static object[] EnterParam(string figure)
        {
            object[] param;
            if (figure == "Text" || figure == "text")
            {
                Console.WriteLine("Enter text:");
                string text = Console.ReadLine();
                Console.WriteLine("Enter x:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter y:");
                int y = int.Parse(Console.ReadLine());
                param = new object[] { text, x, y };
            }
            else
            {
                Console.WriteLine("Enter size:");
                int size = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter operator:");
                string oper = Console.ReadLine();
                Console.WriteLine("Enter x:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter y:");
                int y = int.Parse(Console.ReadLine());
                param = new object[] { size, oper, x, y };
            }
            return param;
        }
        public static string EnterFigure()
        {
            Console.WriteLine("Enter you figure");
            string figure = Console.ReadLine();
            return figure;
        }
        //public static bool EndApp()
        //{

        //}

        public static void DeleteString()
        {
            Console.SetCursorPosition(0, 1);
            Console.Write("                                                         ");
            Console.SetCursorPosition(0, 1);
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
        }

    }
}

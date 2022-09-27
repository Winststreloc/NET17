using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

namespace LEsson8
{
    public class UI
    {
        public static void Hello()
        {
            WriteLine("Hello, enter figure and size{n} and location on x, y \n" +
                "Example: triangle \n5 \n15\n7\n" +
                "If your want clear -  enter clear" +
                "Okey, let s go !");
            Thread.Sleep(2000);
            Clear();
            StartApp();
        }
        public static void StartApp()
        {

            bool endApp = false;
            while (!endApp)
            {
                DeleteString(2);
                WriteLine("Enter figure or word, znak / {skip}, size / {skip}, x, y");
                string figure = ReadLine();
                DeleteString(1);
                if (figure == "triangle" || figure == "square" || figure == "rhombus")
                {
                    try
                    {
                        PrintShape(figure);
                    }
                    catch
                    {
                        Console.WriteLine("В чём проблема ввести нормально?");
                        DeleteString(1);
                        PrintShape(figure);
                    }

                }
                else if (figure == "clear") Console.Clear();
                else
                {
                    try
                    {
                        PrintText(figure);
                    }
                    catch
                    {
                        Console.WriteLine("В чём проблема ввести нормально?");
                        DeleteString(1);
                        PrintText(figure);
                    }
                }

            }

        }
        public static void PrintText(string figure)
        {
            Console.WriteLine("x=");
            Console.SetCursorPosition(2, 1);
            int x = int.Parse(ReadLine());
            DeleteString(1);
            Console.WriteLine("y=");
            Console.SetCursorPosition(2, 1);
            int y = int.Parse(ReadLine());
            DeleteString(2);
            Text text = new Text(x, y);
            text.PrintText(figure, text.Line, text.Column);
        }
        public static void PrintShape(string figure)
        {
            Console.WriteLine("operator:");
            Console.SetCursorPosition(9, 1);
            string _oper = ReadLine();
            DeleteString(1);
            Console.WriteLine("radius / size :");
            Console.SetCursorPosition(15, 1);
            int _size = int.Parse(ReadLine());
            DeleteString(1);
            Console.WriteLine("x:");
            Console.SetCursorPosition(2, 1);
            int _x = int.Parse(ReadLine());
            DeleteString(1);
            Console.WriteLine("y:");
            Console.SetCursorPosition(2, 1);
            int _y = int.Parse(ReadLine());
            DeleteString(2);
            Shape shape = ReturnShape(figure, _x, _y);
            shape.Print(_size, _oper, _x, _y);
        }
        public static void DeleteString(int a)
        {
            if (a == 2)
            {
                SetCursorPosition(0, 0);
                WriteLine("                                                                      ");
                SetCursorPosition(0, 1);
                WriteLine("                                                                      ");
                SetCursorPosition(0, 0);
            }
            else
            {
                SetCursorPosition(0, 1);
                WriteLine("                                                                      ");
                SetCursorPosition(0, 1);
            }

        }

        public static Shape ReturnShape(string text, int column, int line)
        {
            switch (text)
            {
                case "triangle":
                    Triangle triangle = new Triangle(column, line);
                    return triangle;
                case "square":
                    Square square = new Square(column, line);
                    return square;
                case "rhombus":
                    Rhombus rhombus = new Rhombus(column, line);
                    return rhombus;

                default:
                    return default;
            }
        }
    }     
        //TODO Regular expression
        //public void CreateFigure(string param)
        //{
        //    string patternFigures = "(Tr\\.? |Sq\\.? |Rh |Te\\.? )";
        //    string patternNum = @"\d{1,2}";

        //    Match figure = Regex.Match(param, patternFigures);
        //    string shape = figure.ToString();

        //}
}

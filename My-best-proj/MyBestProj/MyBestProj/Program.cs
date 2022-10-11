using System;

namespace MyBestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<int> list = new Tree<int>();
            list.AddNode(5);
            list.AddNode(3);
            list.AddNode(8);
            list.AddNode(7);

            Console.ReadKey();
        }
    }
}

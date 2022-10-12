using System;
using MyBestProj.HomeWork;
using MyBestProj.BinaryTree;

namespace MyBestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BinaryTree


            Tree<int> list = new Tree<int>();
            list.AddNode(5);
            list.AddNode(3);
            list.AddNode(8);
            list.AddNode(7);
            list.AddNode(1);
            list.AddNode(4);
            list.AddNode(6);
            list.AddNode(9);


            #endregion

            #region Table
            //UI.Start();
            #endregion

            Console.ReadKey();
        }
    }
}

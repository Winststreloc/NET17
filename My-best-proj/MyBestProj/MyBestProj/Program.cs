using System;
using MyBestProj.Dictionary;
using MyBestProj.BinaryTree;
using MyBestProj.HomeWork;
using MyBestProj.Queue;
using MyBestProj.Stack;


namespace MyBestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BinaryTree
            //
            //
            // Tree<int> list = new Tree<int>();
            // list.AddNode(5);
            // list.AddNode(3);
            // list.AddNode(8);
            // list.AddNode(7);
            // list.AddNode(7);
            // list.AddNode(1);
            // list.AddNode(4);
            // list.AddNode(6);
            // list.AddNode(9);
            //

            #endregion

            #region Table




            Ui.Start();
            Ui.WorkApp();


            #endregion

            #region Dictionary
            //CoolDictionary<int, string> list = new CoolDictionary<int, string>();

            //list.Add(1, "first");
            //list.Add(2, "second");
            //list.Add(3, "third");

            //string value;
            //bool temp = list.TryGetValue(3, out value);
            #endregion

            #region Stack
            //CoolStack<int> coolStack = new CoolStack<int>();
            //coolStack.Push(0);
            //coolStack.Push(1);
            //coolStack.Push(2);
            //var peekValue = coolStack.Peek();
            //var popValue = coolStack.Pop();
            //coolStack.Print();
            #endregion



            Console.ReadKey();
        }
    }
}

using System;

namespace NewCoolApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<Transformer> list = new LinkedList<Transformer>();
            //list.Add(new Autobots("autobot", 1));
            //list.Add(new Autobots("kremlebot", 2));
            //list.Add(new Decepticons("decepricon", 3));
            //list.Add(new Decepticons("bambolbe", 4));
            //list.Add(new Decepticons("text", 5));
            //list.Add(new Decepticons("test", 6));

            //list.RemoveAt(4);
            //var temp = list.GetElementAt(2);
            //list.Insert(2, new Autobots("BadBoom", 0));

            LinkedList<int> transformers = new LinkedList<int>() { 6, 2, 1, 4 };
            LinkedList<int>.Reverse(transformers);
            LinkedList<int>.SortList(transformers);
            foreach (var type in transformers)
            {
                Console.Write(type);
            }

            Console.ReadKey();
        }
    }
}

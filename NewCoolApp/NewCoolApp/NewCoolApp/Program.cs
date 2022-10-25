using System;

namespace NewCoolApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot(61984595376));
            Console.ReadKey();
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
               

            //LinkedList<int> transformers = new LinkedList<int>();
            //transformers.Add(1);
            //transformers.Add(2);
            //transformers.Add(3);
            //transformers.Add(4);
            //transformers.Add(5);
            //transformers.Add(6);

            //LinkedList<int>.Reverse(transformers);
            //LinkedList<int>.SortList(transformers);
            //foreach (var type in transformers)
            //{
            //    Console.Write(type);
            //}

            //Console.ReadKey();
        }
        public static int DigitalRoot(long n)
        {
            long result = 0;
            while (result == 0)
            {
                while (n > 0)
                {
                    result += n % 10;
                    n /= 10;
                }
                if (result > 10)
                {
                    n = result;
                    result = 0;
                }
            }

            return (int)result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new Counter();

            counter.TickEvent += SomeClass.ProcessTick;
            counter.TickEvent += SomeClass.LogTick;
            var list = new List<Tuple<string, int>>();
            //list.Add("");


        }

        static T ReturnParameters<T>(T item) where T : struct
        {
            return item;
        }
    }

    class MyList<T>
    {
        public T[] list;
    }


    public static class SomeClass
    {
        public static void ProcessTick(int a)
        {
            Console.WriteLine($"Tick processed {a}");

        }

        public static void LogTick(int b)
        {
            Console.WriteLine($"Tick logged {b}");
        }
    }


    public class Counter
    {
        public event Action<int> TickEvent;

        public void Tick(int tickNumber = 5000)
        {
            for (int i = 0; i < tickNumber; i++)
            {
                Thread.Sleep(1000);
                OnTickEvent(i);
            }
        }

        protected virtual void OnTickEvent(int i)
        {
            TickEvent?.Invoke(i);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBestProj.Queue
{
    public class CoolQue<T>
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;

        public void Enqueue(T item)
        {
            items.Add(item);
        }
        public T Dequeue()
        {
            if (Count > 0)
            {
                var item = items[0];
                items.Remove(item);
                return item;
            }
            else throw new Exception("count in Queue < 0");
        }

        public void Clear()
        {
            items.Clear();
        }
        public void Print()
        {
            foreach(var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}

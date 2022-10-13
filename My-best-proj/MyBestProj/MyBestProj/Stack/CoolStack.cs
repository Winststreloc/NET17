using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBestProj.Stack
{
    public class CoolStack<T>
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;

        public void Push(T item)
        {
            items.Add(item);
        }
        public T Pop()
        {
            if (Count > 0)
            {
                var item = items.LastOrDefault();
                items.Remove(items.LastOrDefault());
                return item;
            }
            else throw new Exception("count in stack < 0");
        }
        public T Peek()
        {
            if (Count > 0)
            {
                return items.LastOrDefault();
            }
            else throw new Exception("count in stack < 0");
        }
        public void Clear()
        {
            items.Clear();
        }
        public void Print()
        {
            for(int i = Count; i > 0; i--)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}

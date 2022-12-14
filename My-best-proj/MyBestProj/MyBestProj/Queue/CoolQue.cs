using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBestProj.Queue
{
    public class CoolQue<T>
    {
        private List<T> _items = new List<T>();
        public int Count => _items.Count;

        public void Enqueue(T item)
        {
            _items.Add(item);
        }
        public T Dequeue()
        {
            if (Count > 0)
            {
                var item = _items[0];
                _items.Remove(item);
                return item;
            }
            else throw new Exception("count in Queue < 0");
        }

        public void Clear()
        {
            _items.Clear();
        }
        public void Print()
        {
            foreach(var item in _items)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}

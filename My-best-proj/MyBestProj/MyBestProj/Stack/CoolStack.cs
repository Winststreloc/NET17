using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBestProj.Stack
{
    public class CoolStack<T>
    {
        private List<T> _items = new List<T>();
        public int Count => _items.Count;

        public void Push(T item)
        {
            _items.Add(item);
        }
        public T Pop()
        {
            if (Count > 0)
            {
                var item = _items.LastOrDefault();
                _items.Remove(_items.LastOrDefault());
                return item;
            }
            else throw new Exception("count in stack < 0");
        }
        public T Peek()
        {
            if (Count > 0)
            {
                return _items.LastOrDefault();
            }
            else throw new Exception("count in stack < 0");
        }
        public void Clear()
        {
            _items.Clear();
        }
        public void Print()
        {
            for(int i = Count; i > 0; i--)
            {
                Console.WriteLine(_items[i]);
            }
        }
    }
}

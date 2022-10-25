using System;
using System.Collections;
using System.Text;


namespace NewCoolApp
{
    public class LinkedList<T> : IEnumerable where T : IComparable
    {
        public Node<T> FirstItem { get; private set; }
        public Node<T> LastItem { get; private set; }
        public int Count { get; private set; }
        public LinkedList()
        {
            FirstItem = null;
            LastItem = null;
            Count = 0;
        }

        public LinkedList(T data)
        {
            var item = new Node<T>(data);
            FirstItem = item;
            LastItem = item;
            Count = 1;
        }
        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (LastItem != null)
            {
                LastItem.Next = node;
                LastItem = node;
                Count++;
            }
            else
            {
                AddFirstAndLastElement(node);
            }
        }


        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                FirstItem = FirstItem.Next;
                Count--;
                return;
            }
            var previous = FirstItem;
            var current = FirstItem.Next;
            int counter = 1;
            while (counter != index)
            {
                previous = current;
                current = current.Next;
                counter++;
            }
            previous.Next = current.Next;
            Count--;
        }

        public Node<T> GetElementAt(int index)
        {
            if (index == 0)
            {
                return FirstItem;
            }

            var temp = FirstItem.Next;
            int counter = 1;
            while (counter != index)
            {
                temp = temp.Next;
                counter++;
            }

            return temp;
        }

        public void Insert(int index, T data)
        {
            var nodeValue = new Node<T>(data);
            if (index == 0)
            {
                nodeValue.Next = FirstItem;
                FirstItem = nodeValue;
                Count++;
            }
            var previous = FirstItem;
            var current = FirstItem.Next;
            int counter = 1;
            while (counter != index)
            {
                nodeValue.Next = current;
                previous.Next = nodeValue;
                counter++;
            }
            Count++;
        }
        private void AddFirstAndLastElement(Node<T> item)
        {
            FirstItem = item;
            LastItem = item;
            Count = 1;
        }


        public IEnumerator GetEnumerator()
        {
            int counter = Count;
            var current = FirstItem;
            while (counter != 0)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public static string ToString(LinkedList<T> list)
        {
            StringBuilder text = new StringBuilder();
            var current = list.FirstItem;
            var currentText = list.FirstItem.Data;
            int counter = list.Count;
            while (counter > 0)
            {
                text.Append($"{currentText} ");
                if (current.Next != null)
                {
                    current = current.Next;
                    currentText = current.Data;
                }
                counter--;
            }
            return text.ToString();
        }
        public static void Reverse(LinkedList<T> list)
        {
            Node<T> previous = null;
            Node<T> current = list.FirstItem;
            Node<T> next;
            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            list.FirstItem = previous;
        }


        public static void SortList(LinkedList<T> list)
        {
            var current = list.FirstItem;

            while (current != null)
            {
                var index = current.Next;

                while (index != null)
                {
                    if (current.Data.CompareTo(index.Data) > 0)
                    {
                        (current.Data, index.Data) = (index.Data, current.Data);
                    }
                    index = index.Next;
                }
                current = current.Next;
            }
        }

        public int Compare(T x, T y)
        {
            return x.ToString().Length - y.ToString().Length;
        }
    }

}

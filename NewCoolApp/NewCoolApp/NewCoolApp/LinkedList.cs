using System;
using System.Collections;


namespace NewCoolApp
{
    public class LinkedList<T> : IEnumerable
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

        public override string ToString()
        {
            return base.ToString();
        }


        #region TODO



        #endregion
    }
}

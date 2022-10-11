using System;
using System.Collections.Generic;
using System.Text;

namespace MyBestProj
{
    public  class Node<T> : IComparable
        where T : IComparable
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
        }
        public Node(T data, Node<T> left, Node<T> right) : this(data)
        {
            Left = left;
            Right = right;
        }

        public int CompareTo(object obj)
        {
            return Data.CompareTo(obj);
        }
    }
}

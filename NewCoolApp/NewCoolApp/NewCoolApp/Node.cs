using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace NewCoolApp
{
    public class Node<T> : IComparable
        where T : IComparable
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            Data = data;
        }
        public int CompareTo(object obj)
        {
            return Data.CompareTo(obj);
        }
    }
}

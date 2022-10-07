using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NewCoolApp
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            Data = data;
        }

    }
}

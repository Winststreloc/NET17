﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyBestProj
{
    public  class Node<T> : IComparable<T>
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

        public void Add(T data)
        {
            var node = new Node<T>(data);
            if (data.CompareTo(Data) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }
        public int CompareTo(Node<T> obj)
        {
            if (obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new Exception("Error");
            }
        }

        public int CompareTo(T other)
        {
            return Data.CompareTo(other);
        }
    }
}

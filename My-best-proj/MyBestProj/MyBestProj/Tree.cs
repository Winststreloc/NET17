using System;
using System.Collections.Generic;
using System.Text;

namespace MyBestProj
{
    public class Tree<T>
        where T: IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public void AddNode(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }

            Root.Add(data);
        }

        #region TODO

        public void RemoveNode()
        {

        }

        public void Print()
        {

        }

        #endregion
    }
}

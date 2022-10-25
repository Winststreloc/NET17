using System;
using System.Collections.Generic;
using System.Text;
using MyBestProj.BinaryTree;

namespace MyBestProj.BinaryTree
{
    public class Tree<T>
        where T : IComparable
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

            Count++;
        }

        public void RemoveItem(int key)
        {
            Queue<Node<T>> listNode = new Queue<Node<T>>();
            listNode.Enqueue(Root);
            Node<T> temp = null;
            Node<T> keyNode = null;


            while (listNode.Count != 0)
            {
                temp = listNode.Peek();
                listNode.Dequeue();

                if (temp.Left != null)
                    listNode.Enqueue(temp.Left);

                if (temp.Right != null)
                    listNode.Enqueue(temp.Right);
            }

            //if (keyNode != null)
            //{
            //    int x = temp.Key;
            //    deleteDeepest(root, temp);
            //    keyNode.key = x;
            //}
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

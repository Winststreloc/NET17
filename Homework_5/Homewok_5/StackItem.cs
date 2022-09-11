using System;
using System.Collections.Generic;
using System.Text;

namespace Homewok_5
{
    public class StackItem<E>
    {
        public E value;
        public StackItem<E> next;

        public StackItem(E x)
        {
            value = x;
            next = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyBestProj.Dictionary
{
    public class Item<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public Item(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }


    }
}

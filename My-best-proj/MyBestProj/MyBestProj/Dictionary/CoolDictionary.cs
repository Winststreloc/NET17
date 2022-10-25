using System;
using System.Collections.Generic;
using System.Text;

namespace MyBestProj.Dictionary
{
    public class CoolDictionary<TKey, TValue>
    {
        public List<Item<TKey, TValue>> Items = new List<Item<TKey, TValue>>();
        public List<TKey> Keys = new List<TKey>();

        public CoolDictionary()
        {

        }
        public void Add(TKey key, TValue value)
        {
            if (!Keys.Contains(key))
            {
                var item = new Item<TKey, TValue>(key, value);
                Keys.Add(key);
                Items.Add(item);
            }
            else throw new Exception("List contains this KEY");
        }
        public bool TryGetValue(TKey key, out TValue value)
        {
            foreach(var item in Items)
            {
                if(item.Key.ToString() == key.ToString())
                {
                    value = item.Value;
                    return true;
                }
            }
            value = default(TValue);
            return false;
        }
        public bool TryAdd(TKey key, TValue value)
        {
            if (!Keys.Contains(key))
            {
                var item = new Item<TKey, TValue>(key, value);
                Keys.Add(key);
                Items.Add(item);
                return true;
            }
            else return false;
        }
        public bool ContainsKey(TKey key)
        {
            return Keys.Contains(key) ? true : false;
        }
        public void Clear()
        {
            Items.Clear();
            Keys.Clear();
        }

    }
}

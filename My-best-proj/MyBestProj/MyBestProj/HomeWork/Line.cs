using System;
using System.Collections.Generic;
using System.Text;

namespace MyBestProj.HomeWork
{
    public class Line<T, U, V>
    {
        public T FirstItem { get; set; }
        public U SecondItem { get; set; }
        public V ThirdItem { get; set; }
        public Line<T, U, V> NextLine { get; set; }

        public Line(T firstItem, U secondItem, V thirdItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
            ThirdItem = thirdItem;
        }
    }
}

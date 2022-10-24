
using System;

namespace MyBestProj.HomeWork
{
    public class Line<T, U, V>
    {
        public T FirstItem { get; set; }
        public U SecondItem { get; set; }
        public V ThirdItem { get; set; }
        private DateTime TimeCreate { get; set; }

        public Line(T firstItem, U secondItem, V thirdItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
            ThirdItem = thirdItem;
            TimeCreate = DateTime.Now;
        }
        public override string ToString()
        {
            return FirstItem.ToString() + " " + SecondItem.ToString() + " " + ThirdItem.ToString();
        }
    }
}

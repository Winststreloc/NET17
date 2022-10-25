using System;
using System.Collections.Generic;

namespace MyBestProj.HomeWork
{
    public class Table<T, U, V> : PageInfo
    {
        public event Action<Line<T, U, V>, string> AddInList;
        public event Action<Line<T, U, V>, string> RemoveInList;
        public List<Line<T, U, V>> GenList = new List<Line<T, U, V>>();
        public string FTitle { get; private set;}
        public string STitle { get; private set; }
        public string TTitle { get; private set; }
        public Table()
        {
            FTitle = "First";
            STitle = "Second";
            TTitle = "Third";
            PageSize = 5;
        }
        public Table(T firstItem, U secondItem, V thirdItem, int pageSize)
        {
            var item = new Line<T, U, V>(firstItem, secondItem, thirdItem);
            GenList.Add(item);
            PageSize = pageSize;
        }

        public void Add(T firstItem, U secondItem, V thirdItem)
        {
            var item = new Line<T, U, V>(firstItem, secondItem, thirdItem);
            AddInList(item, "add");
            GenList.Add(item);
            TotalItems++;
        }
        public void Remove(int id)
        {
            RemoveInList(GenList[id], "remove");
            GenList.RemoveAt(id);
            TotalItems--;
        }
        public void AddTitle(string firstTitle, string secondTitle, string thirdTitle)
        {
            FTitle = firstTitle;
            STitle = secondTitle;
            TTitle = thirdTitle;
        }

        public void Print()
        {
            Console.Write($"||{FTitle} ||{STitle} ||{TTitle} || \n");

            for(int i = PageNumber; i < PageNumber + 5; i++)
            {
                try
                {
                    PrintLine(GenList[i]);
                }
                catch
                {
                    Console.WriteLine("null");
                }
                
            }
            Console.WriteLine($"||back||{PageNumber}||next||{TotalPages} ");
        }
        private void PrintLine(Line<T, U, V>  item)
        {
            Console.Write($"||{item.FirstItem} ||");
            Console.Write($"{item.SecondItem} ||");
            Console.Write($"{item.ThirdItem} || \n");
        }
    }
}

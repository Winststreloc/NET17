using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Lesson8.ShapeAndMore;

namespace Lesson8
{
    public class History : HistoryRecord<Shape>
    {

        public HistoryRecord<Shape> HistoryRecord { get; set; }

        public History()
        {
            HistoryRecord = new HistoryRecord<Shape>();
        }
    }


    public class HistoryRecord<T>
    {
        /// <summary>
        /// Why i use array? Because i can)
        /// </summary>
        T[] listValue = new T[10]; 
        DateTime[] timeCreDateTimes = new DateTime[10]; 
        int index = 0;

        public void Add(T value)
        {
            if (index < 10 && index >= 0)
            {
                listValue[index] = value;
                timeCreDateTimes[index] = DateTime.Now;
                index++;
            }
        }
        public void PrintAllFigure()
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"Figure: {listValue[i]} || Time Create: {timeCreDateTimes[i]}");
            }
        }

        public int Count()
        {
            return index;
        }
    }
}

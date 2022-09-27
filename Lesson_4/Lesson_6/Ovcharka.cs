using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_8
{
    public class Ovcharka: Dog
    {
        public Ovcharka()
        {
            Name = "bob";
            Color = "black";
            Tail = 0;
        }

        public Ovcharka(string color, int tail, string name)
        {
            Color = color;
            Tail = tail;
            Name = name;
        }

        public void PlayWithToy(Toys toys)
        {
            Console.WriteLine($"Dog play with{toys}");
        }
        public void Sit()
        {
            Console.WriteLine("Sit");
        }
    }
}

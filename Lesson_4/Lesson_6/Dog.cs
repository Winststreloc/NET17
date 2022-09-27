using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_8
{
    public class Dog
    {
        readonly TailDog tail;
        protected string Color { get; set; }
        protected int Tail { get; set; }
        protected string Name { get; set; }
        public Dog()
        {
            this.tail = new TailDog(100);
        }

        public void Voice()
        {
            Console.WriteLine("Gav");
        }
    }
}

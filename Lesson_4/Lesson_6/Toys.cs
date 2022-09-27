using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_8
{
    public class Toys
    {

        private string Color { get;}
        private string Size { get; set; }

        public readonly string _name;


        public Toys(string color, string name, string size)
        {
            Color = color;
            _name = "Igruha";
            Size = size;
        }
    }

}

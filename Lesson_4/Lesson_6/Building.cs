using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_8
{
    public class Building
    {

        public string Material { get; set; }
        public int Height { get; set; }
        public Building(string material, int height)
        {
            Height = height;
            Material = material;
        }

        public int CreateShadow(int height)
        {
            Height = height;
            return height / 2;
        }
    }
}

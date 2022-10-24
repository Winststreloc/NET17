using System;
using System.Collections.Generic;
using System.Text;

namespace MyBestProj.Graph
{
    public class Vertex
    {
        public int Number { get; set; }
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}

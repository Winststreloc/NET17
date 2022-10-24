using System;
using System.Collections.Generic;
using System.Text;

namespace MyBestProj.Graph
{
    public class Edge
    {
        public Vertex From { get; set; }
        public Vertex To { get; set; }
        public bool Oriented { get; set; }

    }
}

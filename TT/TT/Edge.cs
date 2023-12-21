using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT
{
    internal class Edge
    {
        public Vertex From { get; set; }
        public Vertex To { get; set; }
        public int Weight { get; set; }
        public Edge(Vertex from, Vertex to, int weignt = 1)
        {
            To = to;
            From = from;
            Weight = weignt;
        }
        public override string ToString()
        {
            return $"({From};{To})";
        }
    }
}

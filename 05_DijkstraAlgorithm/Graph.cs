using System;
using System.Collections.Generic;
using System.Text;

namespace _05_DijkstraAlgorithm
{
    class Graph
    {
        Node[] x;
        public Node this[int index] { get { return x[index]; } set { x[index] = value; } }

        public Graph(int count)
        {
            x = new Node[count];
        }
    }
}

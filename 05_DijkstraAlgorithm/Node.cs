using System.Collections.Generic;

namespace _05_DijkstraAlgorithm
{
    class Node
    {
        string name;
        public List<Node> connections = new List<Node>();
        public Dictionary<Node, int> costs = new Dictionary<Node, int>();
        public Node parent;
        public int CheapestWay { get; set; }

        public Node(string name)
        {
            this.name = name;
            CheapestWay = int.MaxValue;
        }

        public override string ToString()
        {
            return name;
        }
    }
}

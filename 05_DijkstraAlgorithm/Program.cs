using System;
using System.Collections.Generic;

namespace _05_DijkstraAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(6);
            graph[0] = new Node("start");
            graph[1] = new Node("a");
            graph[2] = new Node("b");
            graph[3] = new Node("c");
            graph[4] = new Node("d");
            graph[5] = new Node("finish");

            graph[0].connections.Add(graph[1]);
            graph[0].connections.Add(graph[2]);
            graph[0].costs.Add(graph[1], 2);
            graph[0].costs.Add(graph[2], 5);
            graph[0].CheapestWay = 0;

            graph[1].connections.Add(graph[2]);
            graph[1].connections.Add(graph[3]);
            graph[1].costs.Add(graph[2], 8);
            graph[1].costs.Add(graph[3], 7);

            graph[2].connections.Add(graph[3]);
            graph[2].connections.Add(graph[4]);
            graph[2].costs.Add(graph[3], 2);
            graph[2].costs.Add(graph[4], 4);

            graph[3].connections.Add(graph[5]);
            graph[3].costs.Add(graph[5], 1);

            graph[4].connections.Add(graph[3]);
            graph[4].connections.Add(graph[5]);
            graph[4].costs.Add(graph[3], 6);
            graph[4].costs.Add(graph[5], 3);

            DijkstraSearch.Search(graph[0], graph);

            Console.Read();
            
        }
    }
}

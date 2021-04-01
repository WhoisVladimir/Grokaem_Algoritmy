using System;
using System.Collections.Generic;

namespace _05_DijkstraAlgorithm
{
    class DijkstraSearch
    {
        public static void Search(Node node, Graph graph)
        {
            while (node != graph[5])
            {
                foreach (var item in node.connections)
                {
                    Console.WriteLine($"Проверяем связи узла {node} - {item}:");
                    int cost;
                    node.costs.TryGetValue(item, out cost);
                    int estimateCost = node.CheapestWay + cost;
                    Console.WriteLine($"Стоимость соединения: {cost}");
                    Console.WriteLine($"Предполагаемая полная стоимость от узла {node}: {node.CheapestWay} + {cost} = {estimateCost}");
                    if (item.CheapestWay > estimateCost)
                    {
                        item.CheapestWay = estimateCost;
                        item.parent = node;
                        Console.WriteLine($"Для узла {item} обновлён кратчайший путь. Cтоимость: {item.CheapestWay}");
                    }
                }
                node = FindLowestCost(node);
            }
            
            Stack<Node> parents = new Stack<Node>();
            parents = FindAllNodes(graph[5]);

            Console.WriteLine("\nКратчайший путь графа:\n");
            foreach (var item in parents)
            {
                Console.WriteLine(item);
            }

        }

        private static Stack<Node> FindAllNodes(Node node)
        {
            Stack<Node> nodes = new Stack<Node>();

            while (node != null)
            {
                nodes.Push(node);
                node = node?.parent;
            }
            return nodes;
        }

        private static Node FindLowestCost(Node root)
        {
            Node curNode = root.connections[0];
            foreach (var item in root.connections)
            {
                if (item.CheapestWay < curNode.CheapestWay)
                {
                    curNode = item;
                }
            }
            return curNode;
        }
    }
}

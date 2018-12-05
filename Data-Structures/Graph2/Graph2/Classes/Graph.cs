using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Graph2.Classes
{
    class Graph
    {
        public Dictionary<Node, List<Tuple<Node, int>>> AdjacencyList { get; set; }

        public Graph(Node vertex)
        {
            AdjacencyList = new Dictionary<Node, List<Tuple<Node, int>>>();
            List<Tuple<Node, int>> neighbors = new List<Tuple<Node, int>>();
            AdjacencyList.Add(vertex, neighbors);
        }

        public void AddAnEdge(Node parent, Tuple<Node, int> child)
        {
            if (!AdjacencyList.ContainsKey(parent))
            {
                List<Tuple<Node, int>> neighbors = new List<Tuple<Node, int>>();
                AdjacencyList.Add(parent, neighbors);
            }

            var value = AdjacencyList.GetValueOrDefault(parent);
            value.Add(child);

            if (!AdjacencyList.ContainsKey(child.Item1))
            {
                List<Tuple<Node, int>> neighbors = new List<Tuple<Node, int>>();
                AdjacencyList.Add(child.Item1, neighbors);
            }

            value = AdjacencyList.GetValueOrDefault(child.Item1);
            value.Add(new Tuple<Node, int>(parent, child.Item2));

        }
    }
}

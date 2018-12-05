using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Graph2.Classes
{
    class Graph
    {
        public Dictionary<Node, List<Node>> AdjacencyList { get; set; }

        public Graph(Node vertex)
        {
            AdjacencyList = new Dictionary<Node, List<Node>>();
            List<Node> neighbor = new List<Node>();
            AdjacencyList.Add(vertex, neighbor);
        }

    }
}

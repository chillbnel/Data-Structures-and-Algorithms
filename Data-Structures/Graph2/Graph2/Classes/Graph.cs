﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Graph2.Classes
{
    public class Graph
    {
        public Dictionary<Node, List<Tuple<Node, int>>> AdjacencyList { get; set; }

        public Graph(Node vertex)
        {
            AdjacencyList = new Dictionary<Node, List<Tuple<Node, int>>>();
            List<Tuple<Node, int>> neighbors = new List<Tuple<Node, int>>();
            AdjacencyList.Add(vertex, neighbors);
        }

        /// <summary>
        /// Adds an edge to the graph
        /// </summary>
        /// <param name="parent">The parent/first node/vertex</param>
        /// <param name="child">The child/end node/vertex</param>
        public void AddEdge(Node parent, Tuple<Node, int> child)
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

        /// <summary>
        /// Creates a list off all nodes in the in the graph
        /// </summary>
        /// <returns>List of nodes</returns>
        public List<Node> GetNodes()
        {
            List<Node> nodes = new List<Node>();
            foreach(var node in AdjacencyList)
            {
                if(node.Key != null)
                {
                    nodes.Add(node.Key);
                }
            }

            return nodes;
        }

        /// <summary>
        /// Retrieves all neighbors to a target node within a graph
        /// </summary>
        /// <param name="vertex">The graph vertex</param>
        /// <returns>List of neighbor nodes</returns>
        public List<Node> GetNeighbors(Node vertex)
        {
            List<Node> nodeNeighbors = new List<Node>();
            var value = AdjacencyList.GetValueOrDefault(vertex);

            foreach(var node in value)
            {
                nodeNeighbors.Add(node.Item1);
            }

            return nodeNeighbors;
        }
        /// <summary>
        /// Determines the size of the graph and returns it
        /// </summary>
        /// <returns>Graph size</returns>
        public int Size()
        {
            return AdjacencyList.Count;
        }
    }
}

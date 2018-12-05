using System;
using Graph2.Classes;

namespace Graph2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GraphMethodsWork();
        }
        /// <summary>
        /// Prints out the graph to the user
        /// </summary>
        public static void GraphMethodsWork()
        {
            Node node1 = new Graph2.Classes.Node("node1");
            Node node2 = new Graph2.Classes.Node("node2");
            Node node3 = new Graph2.Classes.Node("node3");
            Node node4 = new Graph2.Classes.Node("node4");

            Graph testGraph = new Graph(node1);

            testGraph.AddEdge(node1, new Tuple<Node, int>(node2, 2));
            testGraph.AddEdge(node2, new Tuple<Node, int>(node3, 3));
            testGraph.AddEdge(node3, new Tuple<Node, int>(node4, 4));
            testGraph.AddEdge(node4, new Tuple<Node, int>(node1, 1));

            
            Console.WriteLine("The Graph nodes:");
            foreach (var node in testGraph.GetNodes())
            {
                Console.WriteLine(node.Value);
            }

            Console.WriteLine("The Graph neighbors for first node:");
            foreach (var node in testGraph.GetNeighbors(node1))
            {
                Console.WriteLine(node.Value);
            }

            Console.WriteLine($"The Graph size: {testGraph.Size()}");
        }
    }
}

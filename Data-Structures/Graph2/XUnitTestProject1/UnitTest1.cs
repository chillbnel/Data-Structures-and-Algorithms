using System;
using Graph2.Classes;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Verifies that edges are added to the graph
        /// </summary>
        [Fact]
        public void EdgeAdded()
        {
            Node node1 = new Graph2.Classes.Node("node1");
            Node node2 = new Graph2.Classes.Node("node2");
            Node node3 = new Graph2.Classes.Node("node3");
            Node node4 = new Graph2.Classes.Node("node4");

            Graph testGraph = new Graph(node1);

            testGraph.AddAnEdge(node1, new Tuple<Node, int>(node2, 2));
            testGraph.AddAnEdge(node2, new Tuple<Node, int>(node3, 3));
            testGraph.AddAnEdge(node3, new Tuple<Node, int>(node4, 4));
            testGraph.AddAnEdge(node4, new Tuple<Node, int>(node1, 1));

            Assert.NotEmpty(testGraph.GetNodes());
        }

        /// <summary>
        /// Validates that GetNodes retrieves all nodes in the graph
        /// </summary>
        [Fact]
        public void AllNodesRetrieved()
        {
            Node node1 = new Graph2.Classes.Node("node1");
            Node node2 = new Graph2.Classes.Node("node2");
            Node node3 = new Graph2.Classes.Node("node3");
            Node node4 = new Graph2.Classes.Node("node4");

            Graph testGraph = new Graph(node1);

            testGraph.AddAnEdge(node1, new Tuple<Node, int>(node2, 2));
            testGraph.AddAnEdge(node2, new Tuple<Node, int>(node3, 3));
            testGraph.AddAnEdge(node3, new Tuple<Node, int>(node4, 4));
            testGraph.AddAnEdge(node4, new Tuple<Node, int>(node1, 1));

            Assert.NotEmpty(testGraph.GetNodes());
        }
        /// <summary>
        /// Validates that GetNodeNeighbors retrieves all of the target node's neighbors
        /// </summary>
        [Fact]
        public void AllNeighborsRecieved()
        {
            Node node1 = new Graph2.Classes.Node("node1");
            Node node2 = new Graph2.Classes.Node("node2");
            Node node3 = new Graph2.Classes.Node("node3");
            Node node4 = new Graph2.Classes.Node("node4");

            Graph testGraph = new Graph(node1);

            testGraph.AddAnEdge(node1, new Tuple<Node, int>(node2, 2));
            testGraph.AddAnEdge(node2, new Tuple<Node, int>(node3, 3));
            testGraph.AddAnEdge(node3, new Tuple<Node, int>(node4, 4));
            testGraph.AddAnEdge(node4, new Tuple<Node, int>(node1, 1));

            Assert.NotEmpty(testGraph.GetNodeNeighbors(node2));
        }
    }
}

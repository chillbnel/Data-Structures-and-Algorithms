using System;
using Xunit;
using static Tree.Program;
using System.Collections.Generic;
using Tree.Classes;




namespace TreeTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Validates the Binary Tree depth first transversal using the pre-order method
        /// </summary>
        [Fact]
        public void PreOrderValidation()
        {
            
            Node L1L2 = new Node(99, null, null);
            Node L1R2 = new Node(89, null, null);
            Node L1 = new Node(79, L1L2, L1R2);

            Node R1L2 = new Node(90, null, null);
            Node R1R2 = new Node(100, null, null);
            Node R1 = new Node(70, R1L2, R1R2);

            Node top = new Node(60, L1, R1);

            BinaryTree BinaryTree = new BinaryTree(top);

            BinaryTree.nodes = new List<Node>();
            BinaryTree.nodes = BinaryTree.PreOrder(top);

            Assert.Equal(0, BinaryTree.nodes.IndexOf(top));
        }

        /// <summary>
        /// Validates the Binary Tree depth first transversal using the in-order method
        /// </summary>
        [Fact]
        public void InOrderValidation()
        {

            Node L1L2 = new Node(99, null, null);
            Node L1R2 = new Node(89, null, null);
            Node L1 = new Node(79, L1L2, L1R2);

            Node R1L2 = new Node(90, null, null);
            Node R1R2 = new Node(100, null, null);
            Node R1 = new Node(70, R1L2, R1R2);

            Node top = new Node(60, L1, R1);

            BinaryTree BinaryTree = new BinaryTree(top);

            BinaryTree.nodes = new List<Node>();
            BinaryTree.nodes = BinaryTree.InOrder(top);

            Assert.Equal(3, BinaryTree.nodes.IndexOf(top));
        }
    }
}

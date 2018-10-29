using System;
using Tree.Classes;
using System.Collections.Generic;

namespace Tree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinaryTreePreOrder();
            BinaryTreeInOrder();
            BinaryTreePostOrder();
        }

        public static void BinaryTreePreOrder()
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
            List<Node> preOrder = BinaryTree.PreOrder(top);

            Console.WriteLine("==============Pre-Order==============");
            foreach (Node item in preOrder)
            {
                Console.WriteLine(item.Value);
            }
        }

        public static void BinaryTreeInOrder()
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
            List<Node> inOrder = BinaryTree.InOrder(top);

            Console.WriteLine("==============In-Order==============");
            foreach (Node item in inOrder)
            {
                Console.WriteLine(item.Value);
            }
        }

        public static void BinaryTreePostOrder()
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
            List<Node> postOrder = BinaryTree.PostOrder(top);

            Console.WriteLine("==============Post-Order==============");
            foreach (Node item in postOrder)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}

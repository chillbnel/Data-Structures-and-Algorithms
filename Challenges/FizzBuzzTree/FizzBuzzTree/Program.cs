using System;
using System.Collections.Generic;
using FizzBuzzTree.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node L1L2 = new Node(13, null, null);
            Node L1R2 = new Node(15, null, null);
            Node L1 = new Node(6, L1L2, L1R2);

            Node R1L2 = new Node(3, null, null);
            Node R1R2 = new Node(7, null, null);
            Node R1 = new Node(5, R1L2, R1R2);

            Node top = new Node(1, L1, R1);

            BinaryTree BinaryTree = new BinaryTree(top);

            FizzBuzzTree(BinaryTree, top);
        }

        /// <summary>
        /// Tranverses the tree depth first, pre-orderly and prints the value of each node in the tree; if the node is divisible by 3, 5, or 15 then the value is replaced by "Fizz", "Buzz", or "FizzBuzz" respectively 
        /// </summary>
        /// <param name="tree">Binary tree to be traversed</param>
        /// <param name="top">The tree's root value</param>
        public static void FizzBuzzTree(BinaryTree tree, Node top)
        {
            tree.nodes = new List<Node>();
            List<Node> preOrder = tree.PreOrder(top);

            foreach(var item in preOrder)
            {
                Console.WriteLine(FizzBuzzPrint(item));
            }
        }

        /// <summary>
        /// Checks the value of a node in a series of conditional statements to determine if the value is divisble by 3, 5, or 15
        /// </summary>
        /// <param name="node">Node to be evaluated</param>
        /// <returns>A string of either "Fizz", "Buzz", "FizzBuzz", or the Node's value</returns>
        public static string FizzBuzzPrint(Node node)
        {
            if (node.Value % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (node.Value % 5 == 0)
            {
                return "Buzz";
            }
            else if (node.Value % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return $"{node.Value}";
             }
        }
    }
}

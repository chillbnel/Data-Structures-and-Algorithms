using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
   public class BinaryTree
    {
        public Node Root { get; set; }
        public List<Node> nodes { get; set; }

        public BinaryTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Depth first transversal using the pre-order method
        /// </summary>
        /// <param name="root">the top node in a branch</param>
        /// <returns>the transversed node</returns>
        public List<Node> PreOrder(Node root)
        {
            nodes.Add(root);

            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                PreOrder(root.RightChild);
            }

            return nodes;

        }

        public List<Node> InOrder(Node root)
        {
            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild);
            }

            nodes.Add(root);

            if (root.RightChild != null)
            {
                PreOrder(root.RightChild);
            }

            return nodes;

        }

        static void postOrder()
        {

        }
    }
}

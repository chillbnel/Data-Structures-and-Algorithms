using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
   public class Node
    {
        public int Value { get; set; } //changed from "int" to "object" to ensure that we're not bound to a certain type
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public Node(int value, Node leftChild, Node rightChild)
        {
            Value = value;
            LeftChild = leftChild;
            RightChild = rightChild;
        }
    }
}

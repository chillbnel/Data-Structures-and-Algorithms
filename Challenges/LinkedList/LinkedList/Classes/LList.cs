using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        /// <summary>
        /// Head: Always points to the first node in the LList
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// Current: This is used to transverse the LList
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// LList requires a node at the time of creation to be the HEAD
        /// </summary>
        /// <param name="node"></param>
        public LList(Node node)
        {
            Head = node;
            Current = node;
        }

        //Adds a node at the beginning of the LList, Big O: O(1), no additional memory is being allocated
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        //Traverses LList in order to print, Big O T: O(n), S: O(1)
        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.WriteLine($"{Current.Value}, Next Node Value --> {Current.Next.Value}");
                Current = Current.Next;
            }

            Console.WriteLine($"{Current.Value} --> NULL");
        }

        //Traverses the LList in order to append a new node to the end of the list, Big O T: O(n), S: O(1)
        public void Append(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = newNode;
        }

        //Traverses the LList in order to add a new node immeditely before the target node, Big O T: O(n), S: O(1)
        public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        //Traverses the LList in order to add a new node immeditely after the target node, Big O T: O(n), S: O(1)
        public void AddAfter(Node newNode, Node existingNode)
        {
            Current = Head;

            if (Head.Value == existingNode.Value)
            {
                newNode.Next = Head.Next;
                Head.Next = newNode;
            }
            while (Current.Next != null)
            {
                if (Current.Value == existingNode.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
            Current.Next = newNode;
            newNode.Next = null;
        }

    }
}

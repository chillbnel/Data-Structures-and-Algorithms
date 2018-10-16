using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {
        /// <summary>
        /// Always points to the first node in the LList
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// LL requires a node at the time of creation to be the HEAD
        /// </summary>
        /// <param name="node"></param>
        public LList(Node node)
        {
            Head = node;
            Current = node;
        }

        //adding anode at the beginning: O(1)
        //Space: O(1) because no additional memory is being allocated
        public void Add(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;

        }

        //we must traverse in order to print, so O(n)
        //Space: O(1) because no additional memory is being allocated
        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.WriteLine($"{Current.Value} -->");
                Current = Current.Next;
            }

            Console.WriteLine($"{Current.Value} --> NULL");
            Current = Head;
        }

        //we have to traverse in order so big O is O(n)
        //Space: O(1) because no additional memory is being allocated
        public void Append(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = newNode;
            Current = Head;
        }

        //we have to traverse so big O is O(n)
        //Space: O(1) because no additional memory is being allocated
        public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }

            while (Current.Next.Value == existingNode.Value)
            {
                newNode.Next = existingNode;
                Current.Next = newNode;
                return;
            }
            Current = Current.Next;
        }

        //we have to traverse so big O is O(n)
        //Space: O(1) because no additional memory is being allocated
        public void AddAfter(Node newNode, Node existingNodeAfter)
        {
            Current = Head;
            if (Head.Value == existingNodeAfter.Value)
            {
                newNode.Next = Current.Next;
                Current.Next = newNode;
                return;
            }

            while (Current.Value == existingNodeAfter.Value)
            {
                newNode.Next = Current.Next;
                Current.Next = newNode;
                return;
            }
            Current = Current.Next;
        }
    }
}

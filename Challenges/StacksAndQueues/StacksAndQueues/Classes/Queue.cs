using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Stack s1 = new Stack(null);
        public Stack s2 = new Stack(null);

        public Queue(Node node)
        {
            s1.Push(node);
        }

        /// <summary>
        /// Adds new node to the end of the queue
        /// </summary>
        /// <param name="node">new node</param>
        public void Enqueue(Node node)
        {
            s1.Push(node);
        }

        /// <summary>
        /// Removes node from the front of the queue
        /// </summary>
        /// <returns>removed node</returns>
        public Node Dequeue()
        {
            //transer all nodes from s1 to s2 for correct order
            while (s1.Peek() != null)
            {
                s2.Push(s1.Pop());
            }
            //Node that is being dequeued, "front".
            Node temp = s2.Pop();

            //transfer all nodes back to s1 for correct order with enqueue
            while (s2.Peek() != null)
            {
                s1.Push(s2.Pop());
            }

            return temp;
        }
    }
}

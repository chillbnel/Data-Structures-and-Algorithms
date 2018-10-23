using System;
using Xunit;
using StacksAndQueues.Classes;
using System.Collections.Generic;
using StacksAndQueues;

namespace StackQueueTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Validates that a node can be pushed to a stack
        /// </summary>
        [Fact]
        public void StackPush()
        {
            Node myNode1 = new Node(1);

            Stack Stack = new Stack(null);
            Stack.Push(myNode1);

            Assert.Equal(myNode1, Stack.Peek());

        }
        /// <summary>
        /// Validates that a node can be popped out of the stack
        /// </summary>
        [Fact]
        public void StackPop()
        {
            Node myNode1 = new Node(1);
            Node myNode2 = new Node(1);

            Stack Stack = new Stack(null);
            Stack.Push(myNode1);
            Stack.Push(myNode2);

            Stack.Pop();

            Assert.Equal(myNode1, Stack.Peek());
        }

        /// <summary>
        /// Validates that stack's top node is peeked
        /// </summary>
        [Fact]
        public void StackPeek()
        {
            Node myNode1 = new Node(1);
            Node myNode2 = new Node(1);

            Stack Stack = new Stack(null);
            Stack.Push(myNode1);
            Stack.Push(myNode2);

            Assert.Equal(myNode2, Stack.Peek());
        }

        /// <summary>
        /// Validates that node was added to the queue
        /// </summary>
        [Fact]
        public void QueueEnqueue()
        {
            Node myNode1 = new Node(1);

            Queues Queue = new Queues(myNode1);
          
            Assert.Equal(myNode1, Queue.Peek());
        }

        /// <summary>
        /// Validates that a node was removed from the queue
        /// </summary>
        [Fact]
        public void QueueDequeue()
        {
            {
                Node myNode1 = new Node(1);
                Node myNode2 = new Node(1);

                Queues Queue = new Queues(myNode1);
                Queue.Enqueue(myNode2);

                Queue.Dequeue();

                Assert.Equal(myNode2, Queue.Peek());
            }
        }

        /// <summary>
        /// Validates that the front node in queue is peeked
        /// </summary>
        [Fact]
        public void QueuePeek()
        {
            Node myNode1 = new Node(1);

            Queues Queue = new Queues(myNode1);

            Assert.Equal(myNode1, Queue.Peek());
        }
    }
}

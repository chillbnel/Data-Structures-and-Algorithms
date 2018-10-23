using StacksAndQueues.Classes;
using System;
using Xunit;

namespace QueueTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 1)]
        [InlineData(4, 1)]
        [InlineData(5, 1)]
        public void FirstInFirstOut(int nodeValue, int validRespose)
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(nodeValue);

            Queue queue = new Queue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            //Arrange
            Assert.Equal(validRespose, queue.Dequeue().Value);

        }
    }
}

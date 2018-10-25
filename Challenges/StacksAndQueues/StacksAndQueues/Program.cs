using System;
using StacksAndQueues.Classes;

namespace StacksAndQueues
{
    public class Program
    {
        static void Main(string[] args)
        {
            QueueWithStacks();
        }

        public static void QueueWithStacks()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Queue queue = new Queue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            Console.WriteLine($"The last node added was: {queue.s1.Top.Value}");
            Console.WriteLine($"Dequeued node: {queue.Dequeue().Value}");
        }
    }
}

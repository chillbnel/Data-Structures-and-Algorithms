using System;
using StacksAndQueues.Classes;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Node myNode1 = new Node(1);
            Node myNode2 = new Node(2);
            Node myNode3 = new Node(3);
            Node myNode4 = new Node(4);
            Node myNode5 = new Node(5);

            Console.WriteLine("============= Queues =============");
            Queues myQueue = new Queues(myNode1);
            myQueue.Enqueue(myNode2);
            myQueue.Enqueue(myNode3);
            myQueue.Enqueue(myNode4);
            myQueue.Enqueue(myNode5);

            for (int i =0; i < 5; i++)
            {
                Console.Write($"Peek #{i}: ");
                Console.WriteLine($"{myQueue.Peek().Value}");

                Node removedNode = myQueue.Dequeue();
                Console.WriteLine(removedNode.Value);
            }

            Console.WriteLine("============= Stacks =============");
            Stack myStack = new Stack(myNode1);
            myStack.Push(myNode2);
            myStack.Push(myNode3);
            myStack.Push(myNode4);
            myStack.Push(myNode5);

            myStack.Pop();
            Console.WriteLine($"Second peek: {myStack.Peek().Value}");

            myStack.Pop();
            Console.WriteLine($"Third peek: {myStack.Peek().Value}");

            myStack.Pop();
            Console.WriteLine($"Fourth peek: {myStack.Peek().Value}");

            myStack.Pop();
            Console.WriteLine($"Fifth peek: {myStack.Peek().Value}");
        }
    }
}

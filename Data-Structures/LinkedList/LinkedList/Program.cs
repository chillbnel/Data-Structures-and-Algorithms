using System;
using LinkedList.Classes;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node node1 = new Node(7);
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");

            LList List = new LList(node1);
            List.Add(node2);
            List.Add(node3);

            Console.WriteLine("======= Original List =======");
            List.Print();

            Console.WriteLine("======= Node Appended to the End =======");
            Node node4 = new Node("node4");
            List.Append(node4);
            List.Print();

            Console.WriteLine("======= Node Added Before Node 4 =======");
            Node node5 = new Node("node5");
            List.AddBefore(node5, node4);
            List.Print();

            Console.WriteLine("======= Node Added After Node 5 =======");
            Node node6 = new Node("node6");
            List.AddAfter(node6, node5);
            List.Print();
        }
    }
}

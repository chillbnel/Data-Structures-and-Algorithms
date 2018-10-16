using System;
using LinkedList.Classes;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(7);

            LList myAwesomeList = new LList(node1);

            myAwesomeList.Print();
        }
    }
}

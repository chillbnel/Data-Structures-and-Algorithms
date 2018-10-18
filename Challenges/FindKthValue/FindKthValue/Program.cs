using System;
using LinkedList.Classes;

namespace FindKthValue
{
    class Program
    {
        static void Main(string[] args)//Work with Kris and Vinh on this Whiteboard challenge.
        {
            Node node1 = new Node("node1");
            Node node2 = new Node("node2");
            Node node3 = new Node("node3");

            LList list = new LList(node1);

            FindNode(1, LList);
        }

        /// <summary>
        /// k-th value from the end of a linked list. ​
        /// </summary>
        /// <param name="k">value from the end to find</param>
        /// <param name="list">linked list to be traversed</param>
        /// <returns></returns>
        public static object FindNode(int k, LList list)
        {
            int counter = 0;
            list.Current = list.Head;

            while(list.Current != null)
            {
                counter++;
                list.Current = list.Current.Next;
            }

            list.Current = list.Current.Next;

            try
            {
                if(k > counter)
                {
                    throw new Exception("Value not found in the List");
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }

            for (int i = 0; i < counter - k; i++)
            {
                list.Current = list.Current.Next;
            }

            return list.Current.Value;
        }
    }
}

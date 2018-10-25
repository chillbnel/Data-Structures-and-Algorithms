using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
     public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        //Peek
        public Node Peek()
        {
            return Top;
        }

        //Pop
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        //Push
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
<<<<<<< HEAD:Data-Structures/StacksAndQueues/StacksAndQueues/Stack.cs

=======
>>>>>>> b4afc0b5ae6cc0ea5490eb911cae95c316d1179a:Data-Structures/StacksAndQueues/StacksAndQueues/Classes/Stack.cs
        }


    }
}

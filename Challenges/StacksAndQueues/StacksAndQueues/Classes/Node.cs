using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node
    {
        public Node Top { get; set; }

        public object Value { get; set; }

        public Node Next { get; set; }

        /// <summary>
        /// Constructor for new node
        /// </summary>
        /// <param name="value">value for node</param>
        public Node(object value)
        {
            Value = value;
        }
    }
}

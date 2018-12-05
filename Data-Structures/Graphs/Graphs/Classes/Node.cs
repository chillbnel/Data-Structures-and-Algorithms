using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Node
    {
        public object Value { get; set; }

        public Node(object value)
        {
            Value = value;
        }
    }
}

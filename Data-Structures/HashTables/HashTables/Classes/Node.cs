using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables.Classes
{
    class Node
    {
        public object Value { get; set; } //changed from "int" to "object" to ensure that we're not bound to a certain type
        public Node Next { get; set; }

        public Node(object value)
        {
            Value = value;
        }
    }
}

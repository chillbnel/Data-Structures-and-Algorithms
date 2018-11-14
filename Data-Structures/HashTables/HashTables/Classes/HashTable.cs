using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables.Classes
{
    class HashTable
    {
        /// <summary>
        /// Table with 1024 positions
        /// </summary>
        LinkedList[] Table = new LinkedList[1024];

        /// <summary>
        /// Creates a hash index
        /// </summary>
        /// <param name="key">Key to be hashed</param>
        /// <returns>Hash index</returns>
        public int GetHash(string key)
        {
            int HashIndex = 0;

            foreach (char item in key)
            {
                HashIndex = HashIndex + (int)item;
            }
            HashIndex = (HashIndex * 599) / Table.Length;

            return HashIndex;
        }

        /// <summary>
        /// Checks to see if the Hash table contains the key
        /// </summary>
        /// <param name="key">Key to be checked</param>
        /// <returns></returns>
        public bool Contains(string key)
        {
            bool NotInHashTable = false;

            int HashIndex = GetHash(key);

            if(Table[HashIndex] == null)
            {
                return NotInHashTable;
            }

            Table[HashIndex].Current = Table[HashIndex].Head;
            while (Table[HashIndex].Current != null)
            {
                if((string)Table[HashIndex].Current.Key == key)
                {
                    return true;
                }
                Table[HashIndex].Current = Table[HashIndex].Next;

            }
            return NotInHashTable;
        }
        /// <summary>
        /// Adds key/value pair to the HashTable
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(string key, string value)
        {
            int index = GetHash(key);
            Node node = new Node(key, value);

            if(Cont)

        }
    }
}

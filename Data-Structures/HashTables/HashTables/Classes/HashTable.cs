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
                HashIndex = HashIndex + item;
            }
            HashIndex = (HashIndex * 599) % Table.Length;

            return HashIndex;
        }

        /// <summary>
        /// Finds the Key within Table
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Paired Value</returns>
        public string Find(string key)
        {
            int HashIndex = GetHash(key);

            Table[HashIndex].Current = Table[HashIndex].Head;

            while (Table[HashIndex].Current != null)
            {
                if ((string)Table[HashIndex].Current.Key == key)
                {
                    return $"{(string)Table[HashIndex].Current.Key}: {(string)Table[HashIndex].Current.Value}";
                }
            }

            return null;
        }

        /// <summary>
        /// Checks to see if the Hash table contains the key
        /// </summary>
        /// <param name="key">Key to be checked</param>
        /// <returns>Bool; true if table contains key, false if it doesn't</returns>
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
            int hashIndex = GetHash(key);
            Node node = new Node(key, value);

            if (Contains(key))
            {
                Table[hashIndex].Append(node);
            }
            else
            {
                Table[hashIndex] = new LinkedList(node);
            }
        }
    }
}

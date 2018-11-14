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

    }
}

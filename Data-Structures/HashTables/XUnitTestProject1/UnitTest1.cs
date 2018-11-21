using HashTables.Classes;
using System;
using System.Collections;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    { 

        /// <summary>
        /// Validates adding hash into a hashtable, finding it
        /// </summary>
        [Fact]
        public void HashTableFind()
        {
            HashTable table = new HashTable();
            table.Add("key", "value");

            Assert.Equal("value", table.Find("key"));
        }

        /// <summary>
        /// Validates adding hash into a hashtable, finding it
        /// </summary>
        [Fact]
        public void HashTableFindCollision()
        {
            HashTable table = new HashTable();
            table.Add("Brain", "wrong");
            table.Add("Brian", "correct");

            Assert.Equal("correct", table.Find("Brian"));
        }

        /// <summary>
        /// Validates hashtable contains method
        /// </summary>
        [Fact]
        public void HashTableContains()
        {
            HashTable table = new HashTable();
            table.Add("key", "value");

            Assert.True(table.Contains("key"));
        }

        /// <summary>
        /// Validates hashtable contains method with collision
        /// </summary>
        [Fact]
        public void HashTableContainsCollision()
        {
            HashTable table = new HashTable();
            table.Add("Brain", "wrong");
            table.Add("Brian", "correct");

            Assert.True(table.Contains("Brian"));
        }
    }
}

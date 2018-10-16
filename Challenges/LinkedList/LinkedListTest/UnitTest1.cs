using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(25)]
        public void AddTest(int value)
        {
            LList list = new LList(new Node(7));
            list.Add(new Node(value));
            Assert.True((int)list.Head.Value == value);
        }
    }
}

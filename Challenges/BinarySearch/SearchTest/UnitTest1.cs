using System;
using Xunit;
using BinarySearch;
using static BinarySearch.Program;

namespace SearchTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] array1 = { 4, 8, 15, 16, 23, 42 };
            int key1 = 15;

            Assert.Equal(2, BinarySearchMethod(array1, key1));
        }

        [Fact]
        public void Test2()
        {
            int[] array2 = { 11, 22, 33, 44, 55, 66, 77 };
            int key2 = 90;

            Assert.Equal(-1, BinarySearchMethod(array2, key2));
        }

        [Fact]
        public void Test3()
        {
            int[] array2 = { 2, 4, 6, 8, 10 };
            int key2 = 6;

            Assert.Equal(2, BinarySearchMethod(array2, key2));
        }
    }
}

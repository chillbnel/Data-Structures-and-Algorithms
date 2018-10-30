using System;
using Xunit;
using FizzBuzzTree.Classes;
using static FizzBuzzTree.Program;

namespace FizzBuzzTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Validates values divisble by 3 return "Fizz"
        /// </summary>
        [Fact]
        public void Fizz()
        {
            Node testNode = new Node(6, null, null);
            Assert.Equal("Fizz", FizzBuzzPrint(testNode));
        }

        /// <summary>
        /// Validates values divisble by 5 return "Buzz"
        /// </summary>
        [Fact]
        public void Buzz()
        {
            Node testNode = new Node(10, null, null);
            Assert.Equal("Buzz", FizzBuzzPrint(testNode));
        }

        /// <summary>
        /// Validates values divisble by 15 return "FizzBuzz"
        /// </summary>
        [Fact]
        public void FizzBuzz()
        {
            Node testNode = new Node(30, null, null);
            Assert.Equal("FizzBuzz", FizzBuzzPrint(testNode));
        }

        /// <summary>
        /// Validates all other values are returned as strings
        /// </summary>
        [Fact]
        public void NotFizzBuzz()
        {
            Node testNode = new Node(7, null, null);
            Assert.Equal("7", FizzBuzzPrint(testNode));
        }
    }
}

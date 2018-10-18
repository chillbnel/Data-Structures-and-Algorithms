using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 4, 8, 15, 16, 23, 42 };
            int key1 = 15;

            int[] array2 = { 11, 22, 33, 44, 55, 66, 77 };
            int key2 = 90;

            Console.WriteLine(BinarySearchMethod(array1, key1));
            Console.WriteLine(BinarySearchMethod(array2, key2));
            Console.ReadLine();
        }

        /// <summary>
        /// Conducts a binary search of a 1D array
        /// </summary>
        /// <param name="sortedArray">1D sorted array</param>
        /// <param name="searchKey">key to be found within 1D array</param>
        /// <returns>returns index of key or -1 if key is not in array</returns>
        public static int BinarySearchMethod(int[] sortedArray, int searchKey)
        {
            int first = 0;
            int last = sortedArray.Length - 1;

            while(first <= last)
            {
                int middle = (first + last) / 2;

                if (searchKey == sortedArray[middle])
                {
                    return middle;
                }
                else if (searchKey < sortedArray[middle])
                {
                    last = middle - 1;
                }
                else if (searchKey > sortedArray[middle])
                {
                    first = middle + 1;
                }
            }
            return -1;
        }
    }
}

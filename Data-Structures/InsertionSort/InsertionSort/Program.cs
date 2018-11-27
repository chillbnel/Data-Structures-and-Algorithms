using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Insertion Sort--------");

            int[] unsortedArrayInsertion = new int[] { 1, 10, 2, 9, 3, 8, 4, 6, 5 };
            Console.WriteLine("Unsorted Array");
            foreach (int item in unsortedArrayInsertion)
            {
                Console.WriteLine(item);
            }

            int[] sortedArrayInsertion = InserstionSort(unsortedArrayInsertion);
            Console.WriteLine("Sorted Array");
            foreach (int item in sortedArrayInsertion)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------Quick Sort--------");

            int[] unsortedArrayQuick = new int[] { 1, 10, 2, 9, 3, 8, 4, 6, 5 };
            Console.WriteLine("Unsorted Array");
            foreach (int item in unsortedArrayQuick)
            {
                Console.WriteLine(item);
            }

            int[] sortedArrayQuick = QuickSort(unsortedArrayQuick, 0, unsortedArrayQuick.Length-1);
            Console.WriteLine("Sorted Array");
            foreach (int item in sortedArrayQuick)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("--------Merge Sort--------");

            int[] unsortedArrayMerge = new int[] { 1, 10, 2, 9, 3, 8, 4, 6, 5 };
            Console.WriteLine("Unsorted Array");
            foreach (int item in unsortedArrayMerge)
            {
                Console.WriteLine(item);
            }

            int[] sortedArrayMerge = MergeSort(unsortedArrayMerge);
            Console.WriteLine("Sorted Array");
            foreach (int item in sortedArrayMerge)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Iterates and sorts array using thr insertion sort algorithm
        /// </summary>
        /// <param name="myArray">Sorted array</param>
        static int[] InserstionSort(int[] myArray)
        {
            /*
             * Algorithm:
             * For loop for the outisde to iterate through the list as a whole
             * temp variable is going to hold the current value of index of array[i]
             * Create a new counter (j) one position less than the index of our for loop to determine 
             * if temp is less than the position of j.
             * whioe j is equal to or greater than zero AND the value of temp is less than the position of j
             * - "move" the value of j over one position
             * - "decrement" j back one position
             * once out of the while loop, we know 2 things are posssible
             * -We are at the beginning of the list
             * position of array[j] is less than temp, we know where our temp needs to be inserted, so we should insert the value
             * increment our for loop one more index
             */

            for (int i = 0; i < myArray.Length; i++)
            {
                int temp = myArray[i];
                int j = i - 1;

                while (j >= 0 && temp < myArray[j])
                {
                    myArray[j + 1] = myArray[j];
                    j--;
                }

                myArray[j + 1] = temp;
            }

            return myArray;
        }

        /// <summary>
        /// Iterates and sorts array using the quick sort algorithm
        /// </summary>
        /// <param name="myArray">Sorted array</param>
        static int[] QuickSort(int[] myArray, int left, int right)
        {
            if (left < right)
            {
                // Partition the Algorithm
                int position = Partition(myArray, left, right);
                // Sort the left
                QuickSort(myArray, left, position - 1);
                // Sort the right
                QuickSort(myArray, position + 1, right);
            }

            return myArray;
        }

        /// <summary>
        /// Partitions the array to be quick sorted
        /// </summary>
        /// <param name="arr">Array being sorted</param>
        /// <param name="left">Left boundry</param>
        /// <param name="right">Right boundry</param>
        /// <returns>Lowest Value</returns>
        static int Partition(int[] arr, int left, int right)
        {
            // set a pivot
            int pivot = arr[right];
            // get the index of the lower value
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }

            }

            Swap(arr, right, low + 1);

            return low + 1;
        }

        /// <summary>
        /// Swaps the current value in the array with the lowest value
        /// </summary>
        /// <param name="arr">Array being sorted</param>
        /// <param name="i">Current array index</param>
        /// <param name="low">Lowest array index</param>
        static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }

        /// <summary>
        /// Iterates and sorts array using the merge sort algorithm
        /// </summary>
        /// <param name="myArray">Sorted array</param>
        static int[] MergeSort(int[] myArray)
        {
            if (myArray.Length > 1)
            {
                //establishing sizes of each half of the array
                int leftSize = myArray.Length / 2;
                int rightSize = myArray.Length - leftSize;

                // put the first half in one array (left)
                int[] left = new int[leftSize];
                Array.Copy(myArray, 0, left, 0, leftSize);

                // put the second half in another array (right)
                int[] right = new int[rightSize];
                Array.Copy(myArray, myArray.Length / 2, right, 0, rightSize);

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, myArray);

            }

            return myArray;

        }

        /// <summary>
        /// Merges given side of the of the array
        /// </summary>
        /// <param name="left">left half of midpoint</param>
        /// <param name="right">right half of mid point</param>
        /// <param name="arr">array to be merged</param>
        /// <returns></returns>
        static int[] Merge(int[] left, int[] right, int[] arr)
        {
            // left pointer
            int i = 0;
            // right pointer
            int j = 0;
            // end array pointer
            int k = 0;

            // confirm that each array being compared still has pointers
            while (i < left.Length && j < right.Length)
            {
                // if the value of left array is less than the value of the right array
                if (left[i] <= right[j])
                {
                    // populate the main array with lower value
                    arr[k] = left[i];
                    // immediately increment i.
                    i++;
                }
                else
                {
                    // put the value of the right array into the main array
                    arr[k] = right[j];
                    // increment the pointer of the right
                    j++;
                }
                // increment the pointer in the main array
                k++;
            }


            if (i == left.Length)
            {
                // copy right array into main array
                Array.Copy(right, j, arr, k, right.Length - j);
            }
            else
            {
                Array.Copy(left, i, arr, k, left.Length - i);
            }

            return arr;

        }
    }
}

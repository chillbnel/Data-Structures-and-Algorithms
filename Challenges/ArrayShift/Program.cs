using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int sampleInt1 = 5; //test int
            int[] sampleArr1 = {2,4,6,8};//test array

            ArrayShift(sampleArr1, sampleInt1);//calls method that solves problem, returns an array
        }

        static int[] ArrayShift(int[] arr, int num)
        {
            int[] newArr = new int[arr.Length];//new array that solution is stored
            double middle = (arr.Length / 2);//mid-point of array

            for (int i = 0; i < arr.Length; i++)//iterates through the old array
            {
                if( i < Math.Ceiling(middle))//if below the mid-point it's replaced 1 to 1
                {
                    newArr[i] = arr[i];
                }
                if (i == Math.Ceiling(middle))// at mid-point the passed int is inserted
                {
                    newArr[i] = num;
                }
                if (i > Math.Ceiling(middle))//remaining passed array ints are inserted into the new array
                {
                    newArr[i] = arr[i - 1];
                }
            }

            return newArr;//returns solution in array

        }
    }
}

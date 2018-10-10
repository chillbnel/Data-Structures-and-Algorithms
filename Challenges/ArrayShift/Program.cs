using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int sampleInt1 = 5;
            int[] sampleArr1 = {2,4,6,8};

            ArrayStatic(sampleArr1, sampleInt1);
        }

        static int[] ArrayStatic(int[] arr, int num)
        {
            int[] newArr = new int[arr.Length];
            double middle = (arr.Length / 2);

            for (int i = 0; i < arr.Length; i++)
            {
                if( i < middle)
                {
                    newArr[i] = arr[i];
                }
                if (i == Math.Ceiling(middle))
                {
                    newArr[i] = num;
                }
                if (i > middle)
                {
                    newArr[i] = arr[i - 1];
                }
            }

            return newArr;

        }
    }
}

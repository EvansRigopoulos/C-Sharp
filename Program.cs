using System;

namespace algorithms_in_C
{
    class Program
    {

        static bool LinearSearch(int[] input, int n)
        {
            foreach (int current in input)
            {
                if (n == current)
                {
                    return true;
                }


            }
            return false;

        }

        //if array is sorted asc
        static Boolean BinarySearch(int[] inputArray, int item)
        {
            int min = 0;
            int max = inputArray.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (item == inputArray[mid])
                {
                    return true;
                }
                else if (item < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return false;


        }


        public static int[] Rotate(int[] inputArray)
        {
            int temp = inputArray[0];
            for (int i = 1; i < inputArray.Length; i++)
            {
                inputArray[i - 1] = inputArray[i];
            }
            inputArray[inputArray.Length - 1] = temp;
            return inputArray;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(BinarySearch(arr, 4));
            //Console.WriteLine(Array.Find(arr, element => element == 8));
            Rotate(arr);
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}


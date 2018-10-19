using System;

namespace SortArrayOneThroughK
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Original Array:");
            int[] input = { 1, 2, 3, 4, 1, 4, 7, 4, 5, 6, 2, 5, 12, 3, 10, 10, 11, 12, 1, 0 };

            Console.WriteLine("Now sorted ==========");
            SortThroughK(input, 12);
            PrintToConsole(input);

        }

        /// <summary>
        /// Sorting an array of intergers ranging from 0 to K
        /// </summary>
        /// <param name="arr">Array of unsorted integers</param>
        /// <param name="range">K, highest number found in array</param>
        /// <returns>Returns input array, sorted in place</returns>
        public static int[] SortThroughK(int[] arr, int range)
        {
            int[] sorted = new int[range + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                sorted[arr[i]] += 1;
            }
            
            int count = 0;
            int count2 = 0;

            while (count < arr.Length)
            {
                if (sorted[count2] == 0)
                {
                    count2++;
                }
                else
                {
                    for (int i = 0; i < sorted[count2]; i++)
                    {
                        arr[count++] = count2;
                    }
                    count2++;
                }
            }

            return arr;
        }

        public static void PrintToConsole(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Index{i}: {arr[i]}");
            }
        }
    }
}

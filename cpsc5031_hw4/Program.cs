using System;
using System.Collections.Generic;

/// <summary>
/// Name: David Nguyen
/// HW 4: Merge sort algorithm 
/// </summary>

namespace cpsc5031_hw4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Homework 4");
            Console.WriteLine("--------------------------------------------------");
            //Test case 1
            int[] list1 = new int[1];
            Console.WriteLine("Test Empty - 1 [] -unsorted");

            Console.WriteLine("Splitted Array list and sorted");
            SplitArray(list1, 0, 0);
            Console.WriteLine("Test Empty - 1 [] -sorted");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------");

            //Test case 2
            int[] list2 = new int[] { 0, 1, 2, 3 };
            Console.WriteLine("Test array [0, 1, 2, 3]");

            Console.WriteLine("Splitted Array list and sorted");
            SplitArray(list2, 0, 3);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------");

            //Test case 3
            int[] list3 = new int[] { 0, 1, 2, 3, 4 };
            Console.WriteLine("Test array [0, 1, 2, 3, 4]");

            SplitArray(list3, 0, 4);
            Console.WriteLine("Splitted Array list and sorted");
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------");

            //Test case 4
            int[] list4 = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
            Console.WriteLine("Test array [3, 1, 4, 1, 5, 9, 2, 6, 5]");

            SplitArray(list4, 0, 8);
            Console.WriteLine("Splitted Array list and sorted");
            foreach (var item in list4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------------------------");
            //Test case 5
            int[] list5 = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            Console.WriteLine("Test array [9, 8, 7, 6, 5, 4, 3, 2, 1, 0]");

            SplitArray(list5, 0, 9);
            Console.WriteLine("Splitted Array list and sorted");
            foreach (var item in list5)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Split the Array into smaller array until the length = 1
        /// </summary>
        /// <param name="list">List unsorted items</param>
        /// <param name="firstIndex">start index of the array</param>
        /// <param name="lastIndex">end of the index where the array to be splited</param>
        public static void SplitArray(int[] list, int firstIndex, int lastIndex)
        {
            //base case where length of an array is 1
            if (list.Length <= 1)
            {
                return;
            }
            else
            {
                //verify if length of the array
                if (firstIndex < lastIndex)
                {
                    int mid = (firstIndex + lastIndex) / 2;
                    int secondArrayIndex = mid + 1;
                    SplitArray(list, firstIndex, mid);
                    SplitArray(list, secondArrayIndex, lastIndex);
                    SortAscending(list, secondArrayIndex, lastIndex);
                }

            }
        }


        /// <summary>
        /// Sort an array based on given indexes. 
        /// </summary>
        /// <param name="items">list of unsorted items</param>
        /// <param name="startIndex">start index of the array</param>
        /// <param name="endIndex">end of the index where the array to be sorted</param>
        public static void SortAscending(int[] items, int startIndex, int endIndex)
        {
            int length1 = 0;
            int length2 = 0;

            //create array sizes for even number
            if (CheckEvenNum(items.Length))
            {
                length1 = items.Length / 2;
                length2 = items.Length / 2;
            }
            else
            {
                // create array size for odd number
                double tempLength = items.Length / 2.0;
                int roundedUpNum = (int)Math.Ceiling(tempLength);
                length1 = roundedUpNum;
                length2 = (int)tempLength;
            }

            //create temp array to merge
            int[] list1 = new int[length1];
            int[] list2 = new int[length2];
            int count = 0;
            int list1Count = 0;
            int list2Count = 0;
            //add items to first array
            for (int i = 0; i < length1; i++)
            {
                list1[i] = items[i];
                count++;
            }
            //add items to second array
            for (int i = 0; i < length2; i++)
            {
                list2[i] = items[count];
                count++;
            }

            //merge and sort from two arrays
            count = 0;
            while (list1Count < length1 && list2Count < length2)
            {
                if (list1[list1Count] <= list2[list2Count])
                {
                    items[count] = list1[list1Count];
                    list1Count++;
                }
                else
                {
                    items[count] = list2[list2Count];
                    list2Count++;
                }
                count++;
            }

            //continue add any item left from two arrays after merged them. 
            while (list1Count < length1)
            {
                items[count] = list1[list1Count];
                count++;
                list1Count++;
            }

            while (list2Count < length2)
            {
                items[count] = list2[list2Count];
                count++;
                list2Count++;
            }
        }

        /// <summary>
        /// Function to check if number is an even number or odd number
        /// </summary>
        /// <param name="count">int number</param>
        /// <returns>true/false</returns>
        public static bool CheckEvenNum(int count)
        {
            if (count % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

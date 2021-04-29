using System;
using System.Collections.Generic;

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
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
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
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

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
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }
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
            foreach (var item in list4)
            {
                Console.WriteLine(item);
            }
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
            foreach (var item in list5)
            {
                Console.WriteLine(item);
            }
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
                if (firstIndex < lastIndex)
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
        }

        /// <summary>
        /// method to check if the number is an odd number or even number
        /// </summary>
        /// <param name="count">an integer number to check</param>
        /// <returns>true for the number is an even number and false is odd number</returns>
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

        /// <summary>
        /// Sort an array based on given indexes. 
        /// </summary>
        /// <param name="items">list of unsorted items</param>
        /// <param name="startIndex">start index of the array</param>
        /// <param name="endIndex">end of the index where the array to be sorted</param>
        public static void SortAscending(int[] items, int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                //compare value in each index
                if (i + 1 < endIndex)
                {
                    if (items[i] > items[i + 1])
                    {
                        int smaller = items[i + 1];
                        int bigger = items[i];
                        items[i + 1] = bigger;
                        items[i] = smaller;
                    }
                    else if (items[i] < items[i + 1])
                    {
                        int smaller = items[i];
                        int bigger = items[i + 1];
                        items[i + 1] = smaller;
                        items[i] = bigger;
                    }
                }
            }
        }


    }
}

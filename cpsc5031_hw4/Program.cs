using System;

namespace cpsc5031_hw4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Homework 4");
            int[] unsorted = new int[] { 3, 0, 1, 5 };
            Console.WriteLine("Unsorted array list");
            foreach(var item in unsorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorted array list");
            var sorted = SortAscending(unsorted);
            foreach(var item in sorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Use sort array functions");
            var sortedV2 = SortItems(unsorted);
            foreach(var item in sortedV2)
            {
                Console.WriteLine(item);
            }
            int[] unsortedv2 = new int[] { 3, 0, 1, 5, 8 };
            Console.WriteLine("Unsorted array list -List 2");
            foreach (var item in unsortedv2)
            {
                Console.WriteLine(item);
            }
            var sortedV3 = SortItems(unsortedv2);
            Console.WriteLine("Sorted array list - List 2");
            foreach (var item in sortedV3)
            {
                Console.WriteLine(item);
            }
        }

        public static Array SortItems(int[] items)
        {
            int length = items.Length;
            int[] sorted = new int[length];
            if (CheckEvenNum(items.Length))
            {
                
                int tempLenght = items.Length / 2;
                int[] temp_1 = new int[tempLenght];
                int[] temp_2 = new int[tempLenght];
                for(int i = 0; i < tempLenght; i++)
                {
                    temp_1[i] = items[i];
                }
                for(int i = 0; i < tempLenght; i++)
                {
                    temp_2[i] = items[tempLenght + i];
                }

                var sorted_1 = SortAscending(temp_1);
                var sorted_2 = SortAscending(temp_2);
                sorted_1.CopyTo(sorted, 0);
                sorted_2.CopyTo(sorted, tempLenght);
            }
            else
            {
                //int[] sortedV2 = new int[length];
                double tempLength = items.Length / 2.0;
                int roundedUpNum = (int)Math.Ceiling(tempLength);
                int firstLength = roundedUpNum;
                int secondLength = (int)tempLength;
                int[] temp_a = new int[firstLength];
                int[] temp_b = new int[secondLength];
                for (int i = 0; i < firstLength; i++)
                {
                    temp_a[i] = items[i];
                }
                for (int i = 0; i < secondLength; i++)
                {
                    temp_b[i] = items[roundedUpNum + i];
                }
                var sorted_a = SortAscending(temp_a);
                var sorted_b = SortAscending(temp_b);
                //sorted_a.CopyTo(sortedV2, 0);
                //sorted_b.CopyTo(sortedV2, roundedUpNum);
                //var sortedFinal = SortItems(sortedV2);
                //sortedFinal.CopyTo(sorted, 0);
                sorted_a.CopyTo(sorted, 0);
                sorted_b.CopyTo(sorted, roundedUpNum);
                
            }
            return sorted;
        }

        public static bool CheckEvenNum(int count)
        {
            if(count%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sort integer items in an array.
        /// </summary>
        /// <param name="items">list of unsorted integers</param>
        /// <returns>list of sorted integers</returns>
        public static Array SortAscending(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if(i + 1 < items.Length)
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
                else
                {
                    if (items[i] > items[i - 1])
                    {
                        int smaller = items[i - 1];
                        int bigger = items[i];
                        items[i - 1] = bigger;
                        items[i] = smaller;
                    }
                    else if (items[i] < items[i - 1])
                    {
                        int smaller = items[i];
                        int bigger = items[i - 1];
                        items[i - 1] = smaller;
                        items[i] = bigger;
                    }
                }                
            }
            return items;
        }
    }
}

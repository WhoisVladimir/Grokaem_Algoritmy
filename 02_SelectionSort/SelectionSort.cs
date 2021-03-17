using System;
using System.Collections.Generic;

namespace _02_SelectionSort
{
    class SelectionSort
    {

        public static void SelSort(List<int> list)
        {
            int smallest;
            int smallestIndex;
            List<int> sortedList = new List<int>();
            for (int i = 0; list.Count > 0; i++)
            {
                smallest = list[0];
                smallestIndex = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] < smallest)
                    {
                        smallest = list[j];
                        smallestIndex = j;
                    }
                }
                sortedList.Add(smallest);
                list. RemoveAt(smallestIndex);
            }

            Console.WriteLine("Done:");
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

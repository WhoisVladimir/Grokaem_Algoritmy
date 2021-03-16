using System;
using System.Collections.Generic;
using System.Text;

namespace _01_BinarySearch
{
    class BinarySearch
    {
        public static void Search(int[] arr, int target)
        {
            int low = arr[0];
            int high = arr[arr.Length - 1];

            while (low < high)
            {
                int mid = (low + high)/2;
                int sought = arr[mid];
                if (target < sought)
                {
                    high = arr[mid - 1];
                }
                else if (target > sought)
                {
                    low = arr[mid - 1];
                }
                else if(target == sought)
                {
                    Console.WriteLine($"Найдено в ячейке {mid}");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}

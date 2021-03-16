using System;

namespace _01_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i+1;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            BinarySearch.Search(arr, 17);
        }
    }
}

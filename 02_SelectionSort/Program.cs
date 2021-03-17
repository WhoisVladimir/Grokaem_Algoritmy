using System;
using System.Collections.Generic;

namespace _02_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nonSorted = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                nonSorted.Add(random.Next(100));
            }

            foreach (var item in nonSorted)
            {
                Console.WriteLine(item);
            }

            SelectionSort.SelSort(nonSorted);

            Console.ReadLine();
        }
    }
}

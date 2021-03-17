using System;
using System.Collections.Generic;

namespace _03_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nonSorted = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                nonSorted.Add(random.Next(100));
            }

            foreach (var item in nonSorted)
            {
                Console.WriteLine(item);
            }

            nonSorted = QuickSort.QSort(nonSorted);

            Console.WriteLine("\nDone:\n");
            foreach (var item in nonSorted)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

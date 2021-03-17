using System;
using System.Collections.Generic;
using System.Text;

namespace _03_QuickSort
{
    class QuickSort
    {
        public static List<int> QSort(List<int> list)
        {
            if (list.Count < 2) return list;
            else
            {
                int pivot = list[0];
                List<int> sorted = new List<int>();
                List<int> less = new List<int>();
                List<int> greater = new List<int>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] < pivot) less.Add(list[i]);
                    else if(list[i] > pivot) greater.Add(list[i]);
                }
                less = QSort(less);
                greater = QSort(greater);
                sorted.AddRange(less);
                sorted.Add(pivot);
                sorted.AddRange(greater);
                return sorted;
            }
        }
    }
}

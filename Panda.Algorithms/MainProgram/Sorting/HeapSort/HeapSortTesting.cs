using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;
using Sorting.HeapSort;

namespace MainProgram.Sorting.HeapSort
{
    public class HeapSortTesting
    {
        public static void Test()
        {
            Console.WriteLine(" ======================= TestMaxPriorityQueueWithBinaryHeap");
            Console.WriteLine("Initialize to {S, O, R, T, E, X, A, M, P, L, E}, index start from 1");

            ISort<string> heapSort = new HeapSort<string>();
            var toSort = new string[] { null, "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" };
            heapSort.Sort(toSort);

            Console.WriteLine("After sort:");
            foreach (var item in toSort)
            {
                Console.Write(item + " ");
            }
        }
    }
}

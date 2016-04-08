using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;
using Sorting.MergeSort;

namespace MainProgram.Sorting.MergeSort
{
    public static class MergeSortTesting
    {
        public static void TestMergeSort()
        {
            Console.WriteLine(" ======================= TestMergeSort");
            Console.WriteLine("Initialize an int array queue {0, 5, 7, 1, 9, 2, 3, 6, 4, 8}");

            var array = new int[10] { 0, 5, 7, 1, 9, 2, 3, 6, 4, 8 };
                      
            ISort<int> sort = new MergeSort<int>();
            sort.Sort(array);

            Console.WriteLine("After sorting:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}

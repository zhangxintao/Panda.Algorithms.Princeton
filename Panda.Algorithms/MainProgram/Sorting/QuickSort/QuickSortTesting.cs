using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;
using Sorting.QuickSort;

namespace MainProgram.Sorting.QuickSort
{
    public static class QuickSortTesting
    {
        public static void Test()
        {
            Console.WriteLine(" ======================= TestQuickSort");
            Console.WriteLine("Initialize an int array queue {0, 5, 7, 1, 9, 2, 3, 6, 4, 8}");

            ISort<int> quickSort = new QuickSort<int>();
            var array = new int[10] { 0, 5, 7, 1, 9, 2, 3, 6, 4, 8 };
            quickSort.Sort(array);

            Console.WriteLine("After Sort");
            foreach (var item in array)
            {
                Console.Write(item + "");
            }
        }
    }
}

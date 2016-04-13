using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;
using Sorting.Elementary;

namespace MainProgram.Sorting.Elementary
{
    public class ElementarySortTesting
    {
        public static void TestSelectionSort()
        {
            Console.WriteLine(" ======================= TestSelectionSort");
            Console.WriteLine("Orginal input: {S, O, R, T, E, X, A, M, P, L, E}");
            ISort<string> selectionSort = new SelectionSort<string>();
            var toSort = new string[] { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" };
            selectionSort.Sort(toSort);

            Console.WriteLine("After sort:");
            foreach (var item in toSort)
            {
                Console.Write(item + " ");
            }
        }
    }
}

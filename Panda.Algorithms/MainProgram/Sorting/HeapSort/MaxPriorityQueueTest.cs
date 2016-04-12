using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting.HeapSort;

namespace MainProgram.Sorting.HeapSort
{
    public class MaxPriorityQueueTest
    {
        public static void TestMaxPriorityQueueWithBinaryHeap()
        {
            Console.WriteLine(" ======================= TestMaxPriorityQueueWithBinaryHeap");
            Console.WriteLine("Initialize a string array by the sequence: {P, Q, E, X, A, M, P, L, E}");
            IMaxPriorityQueue<string> mpq = new MaxPriorityQueueWithBinaryHeap<string>(9);

            Console.WriteLine("Insert P, Q, E");
            mpq.Insert("P");
            mpq.Insert("Q");
            mpq.Insert("E");
            Console.WriteLine("DeleteMax : {0}",  mpq.DeleteMax());
            Console.WriteLine();

            Console.WriteLine("Insert X, A, M");
            mpq.Insert("X");
            mpq.Insert("A");
            mpq.Insert("M");
            Console.WriteLine("DeleteMax : {0}", mpq.DeleteMax());
            Console.WriteLine();

            Console.WriteLine("Insert P, L, E");
            mpq.Insert("P");
            mpq.Insert("L");
            mpq.Insert("E");
            Console.WriteLine("DeleteMax : {0}", mpq.DeleteMax());
            Console.WriteLine();
        }
    }
}

using MainProgram.UnionFind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProgram.StackQueueBag;
using MainProgram.Sorting;
using MainProgram.Sorting.MergeSort;
using MainProgram.Sorting.QuickSort;
using MainProgram.Sorting.HeapSort;
using MainProgram.Sorting.Elementary;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //QuickFindTest.TestQuickFind();

            //QuickUnionTest.Test();

            //WeightedQuickUnionTest.Test();

            //StackTest.TestLinkedStack();

            //StackTest.TestArrayStack();

            //QueueTest.ArrayQueueTest();

            //MergeSortTesting.TestMergeSort();

            //QuickSortTesting.Test();

            //MaxPriorityQueueTest.TestMaxPriorityQueueWithBinaryHeap();

            //HeapSortTesting.Test();

            ElementarySortTesting.TestSelectionSort();

            Console.ReadKey();
        }
    }
}

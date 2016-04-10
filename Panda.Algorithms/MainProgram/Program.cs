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

            QuickSortTesting.Test();
            Console.ReadKey();
        }
    }
}

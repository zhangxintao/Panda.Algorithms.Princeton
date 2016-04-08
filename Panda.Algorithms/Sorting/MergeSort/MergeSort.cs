using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.MergeSort
{
    public class MergeSort<T> : ISort<T> where T : IComparable<T> 
    {
        public MergeSort()
        {

        }

        public void Sort(T[] toSort)
        {
            var aux = new T[toSort.Length];
            Sort(toSort, aux, 0, toSort.Length - 1);
        }

        private void Sort(T[] a, T[] aux, int low, int high)
        {
            if (low >= high) return;

            int mid = low + (high - low) / 2;
            Sort(a, aux, low, mid);
            Sort(a, aux, mid + 1, high);
            Merge(a, aux, low, mid, high);
        }

        private void Merge(T[] a, T[] aux, int low, int mid, int high)
        {
            Console.WriteLine("Before merge");
            Console.WriteLine("low:{0}, mid:{1}, high:{2}", low, mid, high);
            foreach(var item in a)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();

            for (int i = low; i <= high; i++)
            {
                aux[i] = a[i];
            }
            int j = low;
            int k = mid + 1;

            for (int index = low; index <= high; index++)
            {
                if (j > mid)
                {
                    Console.WriteLine("in j > mid, j={0},mid={1},k={2}, index={3}", j, mid,k, index);
                    a[index] = aux[k++];
                }
                else if (k > high)
                {
                    Console.WriteLine("k > high, j={0},mid={1},k={2}, index={3}", j, mid, k, index);
                    a[index] = aux[j++];
                }
                else if (LessThan(a[j], a[k]))
                {
                    Console.WriteLine("LessThan(a[j], a[k]), j={0},mid={1},k={2}, index={3}", j, mid, k, index);
                    a[index] = aux[j++];
                }
                else
                {
                    Console.WriteLine("else, j={0},mid={1},k={2}, index={3}", j, mid, k, index);

                    a[index] = aux[k++];
                }
            }

            Console.WriteLine("After Merge");
            foreach (var item in a)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }

        private bool LessThan(T item1, T item2)
        {
            return item1.CompareTo(item2) <= 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.QuickSort
{
    public class QuickSort<T> : ISort<T>  where T : IComparable<T>
    {
        public QuickSort()
        {

        }

        public void Sort(T[] toSort)
        {
            Sort(toSort, 0, toSort.Length - 1);
        }

        private void Sort(T[] a, int low, int high)
        {
            if (low >= high) return;

            var partionIndex = Partition(a, low, high);
            Sort(a, low, partionIndex-1);
            Sort(a, partionIndex + 1, high);
        }

        private int Partition(T[] a, int low, int high)
        {
            int i = low;
            int j = high;
            var item = a[low];

            while(true)
            {
                while (LessThan(a[i], item))
                {
                    if (i >= high) break;
                    i++;
                }

                while (LessThan(item, a[j]))
                {
                    if (j <= low) break;
                    j--;
                }

                if (i >= j) break;

                Exchange(a, i, j);
            }

            Exchange(a, low, j);

            return j;
        }

        private bool LessThan(T item1, T item2)
        {
            return item1.CompareTo(item2) <= 0;
        }

        private void Exchange(T[] a, int item1, int item2)
        {
            var tempItem = a[item1];

            a[item1] = a[item2];
            a[item2] = tempItem;
        }
    }
}

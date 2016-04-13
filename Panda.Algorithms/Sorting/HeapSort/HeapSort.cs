using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.HeapSort
{
    public class HeapSort<T> : ISort<T> where T : IComparable<T>
    {
        public HeapSort()
        {

        }

        public void Sort(T[] toSort)
        {
            int N = toSort.Length - 1;
            for (var i = N / 2; i >= 1; i--)
            {
                Sink(toSort, i, N);
            }

            while (N >= 1)
            {
                Exchange(toSort, N, 1);
                N--;
                Sink(toSort, 1, N);
            }
        }

        private void Sink(T[] a, int k, int N)
        {
            while (2 * k <= N)
            {
                var child = 2 * k;

                if (child < N && Less(a, child, child+1)) child = child + 1;

                if (Less(a, child, k)) break;

                Exchange(a, k, child);

                k = child;
            }
        }

        private bool Less(T[] a, int i, int j)
        {
            return a[i].CompareTo(a[j]) < 0;
        }

        private void Exchange(T[] a, int i, int j)
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}

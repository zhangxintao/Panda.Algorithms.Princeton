using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Elementary
{
    public class SelectionSort<T> : ISort<T> where T : IComparable<T>
    {
        public SelectionSort()
        {
        }

        public void Sort(T[] toSort)
        {
            var N = toSort.Length;
            for (var i = 0; i < N; i++)
            {
                var min = i;
                for (var j = i+1; j < N; j++)
                {
                    if (Less(toSort, j, min)) min = j;
                }
                Exchange(toSort, i, min);
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

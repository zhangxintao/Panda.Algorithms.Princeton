using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Elementary
{
    public class InsertionSort<T> : ISort<T> where T : IComparable<T>
    {
        public InsertionSort()
        {

        }

        public void Sort(T[] toSort)
        {
            var N = toSort.Length;

            for (var i = 0; i < N; i++)
            {
                for (var j = i; j > 0; j--)
                {
                    if (Less(toSort, j-1, j)) break;

                    Exchange(toSort, j - 1, j);
                }
            }
        }

        private bool Less(T[] a, int i, int j)
        {
            return a[i].CompareTo(a[j]) <= 0;
        }

        private void Exchange(T[] a, int i, int j)
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Elementary
{
    public class ShellSort<T> : ISort<T> where T : IComparable<T>
    {
        public void Sort(T[] toSort)
        {
            var N = toSort.Length;
            var h = 1;

            while (h < N / 3)
            { 
                h = 3 * h + 1;
            }

            while (h >= 1)
            {
                for (var i = h; i < N; i++)
                {
                    for (var j = i; j >= h; j = j-h)
                    {
                        if (Less(toSort, j, j - h))
                        {
                            Exchange(toSort, j, j - h);
                        }
                    }
                }
                h = h / 3;
            }
        }

        private void Exchange(T[] a, int i, int j)
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        private bool Less(T[] a, int i, int j)
        {
            return a[i].CompareTo(a[j]) < 0;
        }
    }
}

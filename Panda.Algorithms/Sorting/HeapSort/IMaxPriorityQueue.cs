using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.HeapSort
{
    public interface IMaxPriorityQueue<T> where T : IComparable<T>
    {
        void Insert(T item);
        T Max();
        T DeleteMax();
        bool IsEmpty();
        int Size();
    }
}

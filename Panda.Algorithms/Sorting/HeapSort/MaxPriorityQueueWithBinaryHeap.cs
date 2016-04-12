using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.HeapSort
{
    public class MaxPriorityQueueWithBinaryHeap<T>
        : IMaxPriorityQueue<T>
        where T : IComparable<T>
    {
        private T[] _priorityQueue;
        private int _count = 0;

        public MaxPriorityQueueWithBinaryHeap(int capacity)
        {
            _priorityQueue = new T[capacity + 1];
        }

        public void Insert(T item)
        {
            _priorityQueue[++_count] = item;
            Swim(_count);
        }

        public T DeleteMax()
        {
            var max = _priorityQueue[1];
            Exchange(_priorityQueue, 1, _count);
            _priorityQueue[_count] = default(T);
            _count--;
            Sink(1);
            return max;
        }

        public T Max()
        {
            if (!IsEmpty()) return _priorityQueue[0];

            throw new InvalidOperationException();
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public int Size()
        {
            return _count;
        }

        private void Swim(int k)
        {
            while (k / 2 >= 1)
            {
                var parent = k / 2;
                if(LessThan(_priorityQueue[parent], _priorityQueue[k]))
                {
                    Exchange(_priorityQueue, parent, k);
                }
                k = parent;
            }
        }

        private void Sink(int k)
        {
            while(k * 2 <= _count)
            {
                var childToExchange = k * 2;
                if (LessThan(_priorityQueue[childToExchange], _priorityQueue[childToExchange + 1]))
                {
                    childToExchange = k * 2 + 1;
                }

                if (LessThan(_priorityQueue[childToExchange], _priorityQueue[k])) break;

                Exchange(_priorityQueue, k, childToExchange);
            }
        }
        private void Exchange(T[] a, int i, int j)
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        private bool LessThan(T item1, T item2)
        {
            return item1.CompareTo(item2) < 0;
        }
    }
}

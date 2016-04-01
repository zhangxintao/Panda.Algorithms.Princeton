using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueBag.Queue
{
    public class LinkedQueue<TItem> : IQueue<TItem>
    {
        private Node _head, _tail;
        private int _size = 0;

        public void Enqueue(TItem item)
        {
            var oldTail = _tail;
            _tail = new Node();
            _tail.Item = item;
            _tail.Next = null;
            if (_head == null)
            {
                _head = _tail;
            }
            else
            {
                oldTail.Next = _tail;
            }
            _size++;
        }

        public TItem Dequeue()
        {
            if (IsEmpty()) return default(TItem);

            var oldHead = _head;
            _head = oldHead.Next;

            if (_head == null) _tail = null;

            _size--;
            return oldHead.Item;
        }

        public bool IsEmpty()
        {
            return _head == null;
        }

        public int Size()
        {
            return _size;
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            var index = _head;
            while (index != null)
            {
                var item = index.Item;
                index = index.Next;
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        internal class Node
        {
            internal TItem Item { get; set; }
            internal Node Next { get; set; }
        }
    }
}

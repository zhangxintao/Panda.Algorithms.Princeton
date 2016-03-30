using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueBag.Stack
{
    public class LinkedStack<TItem> : IStack<TItem>
    {
        private Node _first;
        private int _size = 0;

        public IEnumerator<TItem> GetEnumerator()
        {
            while (_first != null)
            {
                var oldItem = _first.Item;

                _first = _first.Next;

                yield return oldItem;
            }
        }

        public TItem Pop()
        {
            if (_first != null)
            {
                var item = _first.Item;
                _first = _first.Next;
                _size--;
                return item;
            }

            return default(TItem);
        }

        public void Push(TItem item)
        {
            if (item == null)
            {
                return;
            }

            var oldFirst = _first;
            _first = new Node();
            _first.Item = item;
            _first.Next = oldFirst;
            _size++;
        }

        public int Size()
        {
            return _size;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        internal class Node
        {
            internal TItem Item { get; set; }
            internal
                Node Next
            { get; set; }
        }
    }
}

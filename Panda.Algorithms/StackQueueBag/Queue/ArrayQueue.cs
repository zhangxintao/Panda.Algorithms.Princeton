using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueBag.Queue
{
    public class ArrayQueue<TItem> : IQueue<TItem>
    {
        private TItem[] _queueArray;
        private int _defaultSize, _queueSize;
        private int head, last;

        public ArrayQueue()
        {
            head = last = 0;
            _queueSize = 0;
            _defaultSize = 10;
            _queueArray = new TItem[_defaultSize];
        }

        public TItem Dequeue()
        {
            if (_queueSize == 0) return default(TItem);

            if (_queueArray.Length / _queueSize == 4) Resize(_queueArray.Length / 2);

            var item = _queueArray[head];
            head++;
            if (head == _queueArray.Length) head = 0;

            return item;
        }

        public void Enqueue(TItem item)
        {
            if(_queueSize == _queueArray.Length)
            {
                Resize(_queueArray.Length * 2);
            }

            _queueArray[last] = item;
            last++;
            if (last == _queueArray.Length) last = 0;

            _queueSize++;
        }

        public bool IsEmpty()
        {
            return _queueSize == 0;
        }

        public int Size()
        {
            return _queueSize;
        }

        private void Resize(int size)
        {
            var tempArray = new TItem[size];

            for (int i = 0; i < _queueSize; i++)
            {
                tempArray[i] = _queueArray[(head + i) % _queueArray.Length];
            }

            _queueArray = tempArray;
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            for(int i = 0; i < _queueSize; i++)
            {
                yield return _queueArray[(head + i) % _queueArray.Length]; 
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

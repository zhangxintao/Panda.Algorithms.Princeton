using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueBag.Stack
{
    public class ArrayStack<TItem> : IStack<TItem>
    {
        private TItem[] _stackArray;
        private readonly int defaultSize = 4;
        private int _stackSize = 0;

        public ArrayStack()
        {
            _stackArray = new TItem[defaultSize];
        }

        public TItem Pop()
        {
            if (_stackSize == 0) return default(TItem);
            if (_stackArray.Length / _stackSize == 4)
            {
                Resize(_stackArray.Length / 2);
            }

            _stackSize--;
            var item = _stackArray[_stackSize];
            _stackArray[_stackSize] = default(TItem);
            return item;
        }

        public void Push(TItem item)
        {
            if (_stackArray.Length == _stackSize)
            {
                Resize(2 * _stackSize);
            }
            _stackArray[_stackSize] = item;
            _stackSize++;
        }

        public int Size()
        {
            return _stackSize;
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            var size = _stackSize;
            while (size > 0)
            {
                size--;
                yield return _stackArray[size];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void Resize(int length)
        {
            var newStackArray = new TItem[length * 2];

            for(var i = 0; i < _stackArray.Length; i++)
            {
                newStackArray[i] = _stackArray[i];
            }
            
            _stackArray = newStackArray;
        }
    }
}

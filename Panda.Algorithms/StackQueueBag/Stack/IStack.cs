using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueBag.Stack
{
    public interface IStack<T> : IEnumerable<T>
    {
        T Pop();
        void Push(T item);
        int Size();
    }
}

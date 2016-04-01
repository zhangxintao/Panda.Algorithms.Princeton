using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueBag.Queue
{
    public interface IQueue<TItem> : IEnumerable<TItem>
    {
        void Enqueue(TItem item);
        TItem Dequeue();
        int Size();
        bool IsEmpty();
    }
}

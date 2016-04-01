using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackQueueBag.Queue;

namespace MainProgram.StackQueueBag
{
    public static class QueueTest
    {
        public static void ArrayQueueTest()
        {
            Console.WriteLine(" ======================= TestArrayQueue");
            Console.WriteLine("Initialize an empty queue");
            IQueue<int> queue = new ArrayQueue<int>();

            Console.WriteLine("Enqueue 1 2 3 4 5");
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine();

            Console.WriteLine("Print queue");
            foreach (var queueItem in queue)
            {
                Console.WriteLine(queueItem);
            }
            Console.WriteLine();

            Console.WriteLine("Dequeue():{0}", queue.Dequeue());
            Console.WriteLine("Dequeue():{0}", queue.Dequeue());
            Console.WriteLine();

            Console.WriteLine("Print Queue");
            foreach (var queueItem in queue)
            {
                Console.WriteLine(queueItem);
            }
        }
    }
}

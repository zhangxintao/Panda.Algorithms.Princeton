using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackQueueBag.Stack;

namespace MainProgram.StackQueueBag
{
    public static class StackTest
    {
        public static void TestLinkedStack()
        {
            Console.WriteLine(" ======================= TestLinkedStack");
            Console.WriteLine("Initialize an empty stack");
            IStack<int> stack = new LinkedStack<int>();
            Console.WriteLine("Push 0 1 2 3 4 to stack");
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine("Pop() = {0}", stack.Pop());
            Console.WriteLine("Pop() = {0}", stack.Pop());
            Console.WriteLine("Travel stack with foreach");
            foreach (var stackItem in stack)
            {
                Console.WriteLine("item:{0}", stackItem);
            }
        }

        public static void TestArrayStack()
        {
            Console.WriteLine(" ======================= TestArrayStack");
            Console.WriteLine("Initialize an empty stack");
            IStack<int> stack = new ArrayStack<int>();
            Console.WriteLine("Push 0 1 2 3 4 5 to stack");
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            
            Console.WriteLine("Travel current stack:");
            foreach (var stackItem in stack)
            {
                Console.WriteLine("item:{0}", stackItem);
            }

            Console.WriteLine("call Pop() 4 times:");
            Console.WriteLine("1 - Pop():{0}", stack.Pop());
            Console.WriteLine("2 - Pop():{0}", stack.Pop());
            Console.WriteLine("3 - Pop():{0}", stack.Pop());
            Console.WriteLine("4 - Pop():{0}", stack.Pop());

            Console.WriteLine("Travel current stack:");
            foreach (var stackItem in stack)
            {
                Console.WriteLine("item:{0}", stackItem);
            }
        }
    }
}

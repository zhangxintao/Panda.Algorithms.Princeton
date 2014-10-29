using System;
using Stacks_Queues.Stacks;

namespace Stacks_Queues.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IStackOfStrings stackOfStrings = new LinkedListImplStackOfString();
            string inputStr;
            while (!string.IsNullOrWhiteSpace(inputStr = Console.ReadLine()))
            {
                if (inputStr == "-")
                {
                    var popItem = stackOfStrings.Pop();
                    Console.WriteLine(popItem ?? "Null");
                }
                else
                {
                    stackOfStrings.Push(inputStr);
                }
            }
        }
    }
}

using System;

namespace Stacks_Queues.Stacks
{
    public class ArrayImplStackOfStrings : IStackOfStrings
    {
        private int count;
        private string[] str;

        public ArrayImplStackOfStrings(int capacity)
        {
            str = new string[capacity];
        }

        public void Push(string item)
        {
            str[count++] = item;
        }

        public string Pop()
        {
            var item = str[--count];
            str[count] = null;
            return item;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}

namespace Stacks_Queues.Stacks
{
    public class LinkedListImplStackOfString : IStackOfStrings
    {
        private Node first;

        private class Node
        {
            public string Item { get; set; }
            public Node Next { get; set; }
        }

        public LinkedListImplStackOfString()
        {
        }

        public void Push(string item)
        {
            var newNode = new Node {Item = item, Next = first};
            first = newNode;
        }

        public string Pop()
        {
            if (IsEmpty()) return null;

            var popItem = first.Item;
            first = first.Next;
            return popItem;
        }

        public bool IsEmpty()
        {
            return first == null;
        }
    }
}
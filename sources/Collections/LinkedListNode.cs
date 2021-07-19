namespace VSU.Collections
{
    public sealed partial class LinkedList<T>
    {
        private class LinkedListNode: ILinkedListNode<T>
        {
            public T Value { get; set; }

            public LinkedListNode Next { get; set; }

            ILinkedListNode<T> ILinkedListNode<T>.Next => Next;

            public LinkedListNode(T value, LinkedListNode next = default)
            {
                Value = value;
                Next = next;
            }
        }
    }
}

namespace VSU.Collections
{
    public sealed partial class SortedLinkedList<T>
    {
        private class SortedLinkedListNode : ILinkedListNode<T>
        {
            public T Value { get; set; }

            public ILinkedListNode<T> Next { get; set; }

            public SortedLinkedListNode(T value, ILinkedListNode<T> next = null)
            {
                Value = value;
                Next = next;
            }
        }
    }
}

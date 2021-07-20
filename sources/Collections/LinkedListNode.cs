namespace VSU.Collections
{
    public sealed partial class LinkedList<T>
    {
        /// <summary>
        /// Представляет узел односвязного списка.
        /// </summary>
        private class LinkedListNode: ILinkedListNode<T>
        {
            public T Value { get; set; }

            /// <summary>
            /// Следующий узел.
            /// </summary>
            public LinkedListNode Next { get; set; }

            ILinkedListNode<T> ILinkedListNode<T>.Next => Next;

            /// <summary>
            /// Представляет узел односвязного списка.
            /// </summary>
            /// <param name="value">Значение.</param>
            /// <param name="next">Следующий узел.</param>
            public LinkedListNode(T value, LinkedListNode next = default)
            {
                Value = value;
                Next = next;
            }
        }
    }
}

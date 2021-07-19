using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VSU.Collections
{
    public sealed partial class LinkedList<T> : ICollection<T>, IReadOnlyCollection<T>
    {
        private readonly IEqualityComparer<T> _equalityComparer;
        private LinkedListNode _head;

        public int Count { get; private set; }
        public bool IsReadOnly => false;

        public bool IsEmpty()
            => _head == default;

        public void Add(T item)
            => AddAfter(item);

        public LinkedList(IEqualityComparer<T> equalityComparer = default)
        {
            _equalityComparer = equalityComparer ?? EqualityComparer<T>.Default;
            Clear();
        }

        public LinkedList(T element, IEqualityComparer<T> equalityComparer = default)
            : this(equalityComparer)
        {
            _head = new LinkedListNode(element);
            Count = 1;
        }

        public ILinkedListNode<T> AddBefore(T item, ILinkedListNode<T> node = default)
        {
            if (node != null && node is not LinkedListNode)
                throw new ArgumentException("Вершина была порождена вне класса LinkedList.", nameof(node));

            var listNode = node as LinkedListNode ?? _head;

            var newNode = new LinkedListNode(item, listNode);

            if (listNode == _head)
                _head = newNode;
            else
            {
                LinkedListNode temp = _head;
                while (temp.Next != listNode)
                    temp = temp.Next;
                temp.Next = newNode;
            }

            ++Count;
            return newNode;
        }

        public ILinkedListNode<T> AddAfter(T item, ILinkedListNode<T> node = default)
        {
            if (node != null && node is not LinkedListNode)
                throw new ArgumentException("Вершина была порождена вне класса LinkedList.", nameof(node));
            
            if (IsEmpty())
            {
                _head = new LinkedListNode(item);
                return _head;
            }

            var listNode = (node ?? GetNodeEnumerable().LastOrDefault()) as LinkedListNode;
            var newNode = new LinkedListNode(item, listNode.Next);
            listNode.Next = newNode;
            ++Count;
            return newNode;
        }

        public void Clear()
        {
            _head = default;
            Count = 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentException("Array is null.", nameof(array));

            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(arrayIndex), "Array index is less than 0.");

            if (Count > array.Length - arrayIndex)
                throw new ArgumentException("The number of elements in the source collection is greater than the available space from arrayIndex to the end of the destination array.");

            foreach (var element in this)
                array[arrayIndex++] = element;
        }

        public IEnumerable<ILinkedListNode<T>> GetNodeEnumerable()
        {
            ILinkedListNode<T> node = _head;
            while (node != null)
            {
                yield return node;
                node = node.Next;
            }
        }

        public bool Contains(T item)
            => ((IEnumerable<T>)this).Contains(item, _equalityComparer);

        public IEnumerator<T> GetEnumerator()
            => GetNodeEnumerable()
                .Select(node => node.Value)
                .GetEnumerator();

        public bool Remove(T item)
        {
            if (!IsEmpty())
            {
                if (_equalityComparer.Equals(_head.Value, item))
                {
                    _head = _head.Next;
                    return true;
                }
                else
                {
                    LinkedListNode temp = _head;
                    while (temp != null && !_equalityComparer.Equals(temp.Next.Value, item))
                        temp = temp.Next;

                    if (temp != null)
                    {
                        LinkedListNode forDel = temp.Next;
                        temp.Next = temp.Next.Next;
                        forDel.Next = null;
                        return true;
                    }
                }
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}

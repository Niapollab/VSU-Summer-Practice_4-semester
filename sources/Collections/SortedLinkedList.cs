using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VSU.Collections
{
    public sealed class SortedLinkedList<T> : ICollection<T>, IReadOnlyCollection<T>
    {
        private readonly LinkedList<T> _list;
        private readonly IComparer<T> _comparer;

        public SortedLinkedList(Comparer<T> comparer = default, EqualityComparer<T> equalityComparer = default)
        {
            _list = new LinkedList<T>(equalityComparer);
            _comparer = comparer ?? Comparer<T>.Default;
        }

        public SortedLinkedList(Comparison<T> comparison, EqualityComparer<T> equalityComparer = default)
            : this(Comparer<T>.Create(comparison), equalityComparer)
        {

        }

        public int Count => _list.Count;

        public bool IsReadOnly => _list.IsReadOnly;

        public bool IsEmpty()
            => _list.IsEmpty();

        public void Add(T item)
        {
            if (IsEmpty())
                _list.AddBefore(item);
            else
            {
                if (_comparer.Compare(_list.Head.Value, item) >= 0)
                    _list.AddBefore(item);
                else
                {
                    ILinkedListNode<T> temp = _list.Head;
                    while (temp.Next != null && _comparer.Compare(temp.Next.Value, item) < 0)
                        temp = temp.Next;
                    _list.AddAfter(item, temp);
                }
            }
        }

        public void Clear()
            => _list.Clear();

        public bool Contains(T item)
            => _list.Contains(item);

        public void CopyTo(T[] array, int arrayIndex)
            => _list.CopyTo(array, arrayIndex);

        public IEnumerable<ILinkedListNode<T>> GetNodeEnumerable()
            => _list.GetNodeEnumerable();

        public IEnumerator<T> GetEnumerator()
            => _list.GetEnumerator();

        public bool Remove(T item)
            => _list.Remove(item);

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}

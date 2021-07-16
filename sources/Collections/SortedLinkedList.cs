using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace VSU.Collections
{
    /// <summary>
    /// Представляет класс односвязного линейного списка с сортировкой при добавлении элементов.
    /// </summary>
    /// <typeparam name="T">Тип элементов списка.</typeparam>
    public sealed partial class SortedLinkedList<T> : ICollection<T>, IReadOnlyCollection<T>
    {
        /// <summary>
        /// Голова односвязного списка.
        /// </summary>
        private SortedLinkedListNode _head;

        /// <summary>
        /// Правила сравнения элементов при сортировке списка.
        /// </summary>
        private Comparer<T> _comparer;

        /// <summary>
        /// Правила сравнения элементов при поиске в списке.
        /// </summary>
        private EqualityComparer<T> _equalityComparer;

        /// <summary>
        /// Инициализирует класс односвязного линейного списка с сортировкой при добавлении элементов.
        /// </summary>
        /// <param name="comparer">Правила сравнения элементов при сортировке списка.</param>
        /// <param name="equalityComparer">Правила сравнения элементов при поиске в списке.</param>
        public SortedLinkedList(Comparer<T> comparer = null, EqualityComparer<T> equalityComparer = null)
        {
            Clear();
            _comparer = comparer ?? Comparer<T>.Default;
            _equalityComparer = equalityComparer ?? EqualityComparer<T>.Default;
        }

        /// <summary>
        /// Инициализирует класс односвязного линейного списка с сортировкой при добавлении элементов.
        /// </summary>
        /// <param name="comparison">Правила сравнения элементов при сортировке списка.</param>
        /// <param name="equalityComparer">Правила сравнения элементов при поиске в списке.</param>
        public SortedLinkedList(Comparison<T> comparison, EqualityComparer<T> equalityComparer = null) : this(Comparer<T>.Create(comparison), equalityComparer) 
        {

        }

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public bool IsEmpty()
            => _head == null;

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            _head = null;
            Count = 0;
        }

        public bool Contains(T item)
            => ((IEnumerable<T>)this).Contains(item, _equalityComparer);

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
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

        public IEnumerator<T> GetEnumerator()
            => GetNodeEnumerable()
                .Select(node => node.Value)
                .GetEnumerator();

        public bool Remove(T item)
        {
            if (!IsEmpty())
            {
                ILinkedListNode<T> firstEqualsToItem = GetNodeEnumerable().FirstOrDefault((element) => _equalityComparer.Equals(element.Value, item));
                if (firstEqualsToItem != null)
                {
                    throw new NotImplementedException();
                }
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}

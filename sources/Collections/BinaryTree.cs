using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VSU.Collections
{
    public sealed partial class BinaryTree<T> : ICollection<T>
    {
        private BinaryTreeNode _root;

        private readonly Comparer<T> _comparer;

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public ITreeNode<T> Root => _root;

        public bool IsEmpty => _root == null;

        public BinaryTree(Comparer<T> comparer = null)
        {
            _comparer = comparer ?? Comparer<T>.Default;
            Clear();
        }

        public BinaryTree(Comparison<T> comparison) : this(Comparer<T>.Create(comparison))
        {

        }

        public void Add(T item)
        {
            _root = Insert(_root, item);
            ++Count;
        }

        public void Clear()
        {
            Count = 0;
            _root = null;
        }
        public bool Contains(T item)
           => Find(item) != null;

        public ITreeNode<T> Find(T item)
        {
            BinaryTreeNode currentNode = _root;
            while (currentNode != null)
            {
                switch (_comparer.Compare(item, currentNode.Value))
                {
                    case 0:
                        return currentNode;
                    case 1:
                        currentNode = currentNode.RightChild;
                        break;
                    case -1:
                        currentNode = currentNode.LeftChild;
                        break;
                }
            }
            return null;
        }

        private BinaryTreeNode Insert(BinaryTreeNode node, T item)
        {
            if (node == null)
                return new BinaryTreeNode(item);

            if (_comparer.Compare(item, node.Value) < 0)
                node.LeftChild = Insert(node.LeftChild, item);
            else
                node.RightChild = Insert(node.RightChild, item);

            return node;
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

        private IEnumerable<BinaryTreeNode> EnumerateAllNodes()
        {
            if (!IsEmpty)
            {
                var nodes = new Stack<BinaryTreeNode>();
                BinaryTreeNode currentNode = _root;
                while (nodes.Count > 0 || currentNode != null)
                {
                    if (currentNode != null)
                    {
                        nodes.Push(currentNode);
                        currentNode = currentNode.LeftChild;
                    }
                    else
                    {
                        currentNode = nodes.Pop();
                        yield return currentNode;

                        currentNode = currentNode.RightChild;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
            => EnumerateAllNodes()
                .Select(node => node.Value)
                .GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        public bool Remove(T item)
        {
            int startCount = Count;
            _root = Remove(_root, item);
            return Count != startCount;
        }

        private BinaryTreeNode Remove(BinaryTreeNode node, T item)
        {
            if (node == null)
                return null;

            switch (_comparer.Compare(item, node.Value))
            {
                case -1:
                    node.LeftChild = Remove(node.LeftChild, item);
                    break;
                case 1:
                    node.RightChild = Remove(node.RightChild, item);
                    break;
                case 0:
                    {
                        --Count;

                        BinaryTreeNode q = node.LeftChild;
                        BinaryTreeNode r = node.RightChild;

                        if (r == null)
                            return q;

                        BinaryTreeNode min = EnumerateAllNodes().First();
                        min.RightChild = RemoveMinElement(r);
                        min.LeftChild = q;

                        return min;
                    }
            }

            return node;
        }

        private static BinaryTreeNode RemoveMinElement(BinaryTreeNode node)
        {
            if (node.LeftChild == null)
                return node.RightChild;
            node.LeftChild = RemoveMinElement(node.LeftChild);

            return node;
        }
    }
}

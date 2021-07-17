using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VSU.Collections
{
    public sealed partial class AVLTree<T> : ICollection<T>, ICloneable
    {
        private AVLTreeNode _root;

        private readonly Comparer<T> _comparer;

        public ITreeNode<T> Root => _root;

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public bool IsEmpty => _root == null;

        public AVLTree(Comparer<T> comparer = null)
        {
            _comparer = comparer ?? Comparer<T>.Default;
            Clear();
        }

        public AVLTree(Comparison<T> comparison) : this(Comparer<T>.Create(comparison))
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
            AVLTreeNode currentNode = _root;
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

        private IEnumerable<AVLTreeNode> EnumerateAllNodes()
        {
            if (!IsEmpty)
            {
                var nodes = new Stack<AVLTreeNode>();
                AVLTreeNode currentNode = _root;
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

        public bool Remove(T item)
        {
            int startCount = Count;
            _root = Remove(_root, item);
            return Count != startCount;
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        private static byte GetHeight(AVLTreeNode node)
            => node?.Height ?? 0;

        private static int GetBalanceFactor(AVLTreeNode node)
            => GetHeight(node.RightChild) - GetHeight(node.LeftChild);

        private static void FixHeight(AVLTreeNode node)
        {
            byte hl = GetHeight(node.LeftChild);
            byte hr = GetHeight(node.RightChild);
            node.Height = (byte)((hl > hr ? hl : hr) + 1);
        }

        private static AVLTreeNode RightRotate(AVLTreeNode node)
        {
            AVLTreeNode temp = node.LeftChild;
            node.LeftChild = temp.RightChild;
            temp.RightChild = node;

            FixHeight(node);
            FixHeight(temp);

            return temp;
        }

        private static AVLTreeNode LeftRotate(AVLTreeNode node)
        {
            AVLTreeNode temp = node.RightChild;
            node.RightChild = temp.LeftChild;
            temp.LeftChild = node;

            FixHeight(temp);
            FixHeight(node);

            return temp;
        }

        private static AVLTreeNode Balance(AVLTreeNode node)
        {
            FixHeight(node);
            if (GetBalanceFactor(node) > 1)
            {
                if (GetBalanceFactor(node.RightChild) < 0)
                    node.RightChild = RightRotate(node.RightChild);
                return LeftRotate(node);
            }
            else if (GetBalanceFactor(node) < -1)
            {
                if (GetBalanceFactor(node.LeftChild) > 0)
                    node.LeftChild = LeftRotate(node.LeftChild);
                return RightRotate(node);
            }
            return node;
        }

        private AVLTreeNode Insert(AVLTreeNode node, T item)
        {
            if (node == null)
                return new AVLTreeNode(item);

            if (_comparer.Compare(item, node.Value) < 0)
                node.LeftChild = Insert(node.LeftChild, item);
            else
                node.RightChild = Insert(node.RightChild, item);

            return Balance(node);
        }

        private static AVLTreeNode RemoveMinElement(AVLTreeNode node)
        {
            if (node.LeftChild == null)
                return node.RightChild;
            node.LeftChild = RemoveMinElement(node.LeftChild);

            return Balance(node);
        }

        private AVLTreeNode Remove(AVLTreeNode node, T item)
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

                        AVLTreeNode q = node.LeftChild;
                        AVLTreeNode r = node.RightChild;

                        if (r == null)
                            return q;

                        AVLTreeNode min = EnumerateAllNodes().First();
                        min.RightChild = RemoveMinElement(r);
                        min.LeftChild = q;

                        return Balance(min);
                    }
            }

            return Balance(node);
        }

        public object Clone()
        {
            var copy = new AVLTree<T>(_comparer);

            foreach (var element in this)
                copy.Add(element);

            return copy;
        }
    }
}
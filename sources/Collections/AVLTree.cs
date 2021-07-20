using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VSU.Collections
{
    /// <summary>
    /// Представляет класс AVL-Дерева.
    /// </summary>
    /// <typeparam name="T">Тип элемента.</typeparam>
    public sealed partial class AVLTree<T> : ICollection<T>
    {
        /// <summary>
        /// Корень.
        /// </summary>
        private AVLTreeNode _root;

        /// <summary>
        /// Правило сравнения элементов.
        /// </summary>
        private readonly Comparer<T> _comparer;

        /// <summary>
        /// Корень.
        /// </summary>
        public ITreeNode<T> Root => _root;

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        /// <summary>
        /// Является ли дерево пустым.
        /// </summary>
        public bool IsEmpty => _root == null;

        /// <summary>
        /// Инициализирует класс AVL-Дерева.
        /// </summary>
        /// <param name="comparer">Правило сравнения элементов.</param>
        public AVLTree(Comparer<T> comparer = null)
        {
            _comparer = comparer ?? Comparer<T>.Default;
            Clear();
        }

        /// <summary>
        /// Инициализирует класс AVL-Дерева.
        /// </summary>
        /// <param name="comparison">Правило сравнения элементов.</param>
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

        /// <summary>
        /// Выполняет поиск узла в дереве и возвращает его, если оно найдено. Во всех остальных случаях возвращает null.
        /// </summary>
        /// <param name="item">Элемент.</param>
        /// <returns>Узел в дереве.</returns>
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

        /// <summary>
        /// Перечисляет все узлы дерева в порядке их возрастания относительно правила сравнения.
        /// </summary>
        /// <returns>Перечисление всех узлов.</returns>
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

        /// <summary>
        /// Возвращет высоту в узле.
        /// </summary>
        /// <param name="node">Узел.</param>
        /// <returns>Высота в узле.</returns>
        private static byte GetHeight(AVLTreeNode node)
            => node?.Height ?? 0;

        /// <summary>
        /// Вычисляет степень сбалансированности между двумя поддеревьями узла.
        /// </summary>
        /// <param name="node">Узел.</param>
        /// <returns>Степень сбалансированности между двумя поддеревьями.</returns>
        private static int GetBalanceFactor(AVLTreeNode node)
            => GetHeight(node.RightChild) - GetHeight(node.LeftChild);

        /// <summary>
        /// Исправляет высоту в узле.
        /// </summary>
        /// <param name="node">Узел.</param>
        private static void FixHeight(AVLTreeNode node)
        {
            byte hl = GetHeight(node.LeftChild);
            byte hr = GetHeight(node.RightChild);
            node.Height = (byte)((hl > hr ? hl : hr) + 1);
        }

        /// <summary>
        /// Выполянет правый поворот.
        /// </summary>
        /// <param name="node">Узел, вокруг которого совершается поворот.</param>
        /// <returns>Узел, который теперь является головным.</returns>
        private static AVLTreeNode RightRotate(AVLTreeNode node)
        {
            AVLTreeNode temp = node.LeftChild;
            node.LeftChild = temp.RightChild;
            temp.RightChild = node;

            FixHeight(node);
            FixHeight(temp);

            return temp;
        }

        /// <summary>
        /// Выполянет левый поворот.
        /// </summary>
        /// <param name="node">Узел, вокруг которого совершается поворот.</param>
        /// <returns>Узел, который теперь является головным.</returns>
        private static AVLTreeNode LeftRotate(AVLTreeNode node)
        {
            AVLTreeNode temp = node.RightChild;
            node.RightChild = temp.LeftChild;
            temp.LeftChild = node;

            FixHeight(temp);
            FixHeight(node);

            return temp;
        }

        /// <summary>
        /// Выполняет балансировку дерева.
        /// </summary>
        /// <param name="node">Узел, вокруг которого совершается поворот.</param>
        /// <returns>Узел, который теперь является головным.</returns>
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

        /// <summary>
        /// Выполянет вставку в дерево.
        /// </summary>
        /// <param name="node">Текущее рассматриваемое поддерево.</param>
        /// <param name="item">Элемент для вставки.</param>
        /// <returns>Узел, который теперь является головным.</returns>
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

        /// <summary>
        /// Выполняет удаление минимального узла.
        /// </summary>
        /// <param name="node">Узел.</param>
        /// <returns>Узел, который теперь является головным.</returns>
        private static AVLTreeNode RemoveMinElement(AVLTreeNode node)
        {
            if (node.LeftChild == null)
                return node.RightChild;
            node.LeftChild = RemoveMinElement(node.LeftChild);

            return Balance(node);
        }

        /// <summary>
        /// Выполняет удаление из дерева.
        /// </summary>
        /// <param name="node">Узел.</param>
        /// <param name="item">Элемент.</param>
        /// <returns>Узел, который теперь является головным.</returns>
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
    }
}
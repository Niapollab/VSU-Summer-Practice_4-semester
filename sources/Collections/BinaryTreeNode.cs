namespace VSU.Collections
{
    public sealed partial class BinaryTree<T>
    {
        /// <summary>
        /// Представляет класс узла бинарного дерева. 
        /// </summary>
        private class BinaryTreeNode : ITreeNode<T>
        {
            public T Value { get; set; }

            /// <summary>
            /// Левый ребенок.
            /// </summary>

            public BinaryTreeNode LeftChild { get; set; }

            /// <summary>
            /// Правый ребенок.
            /// </summary>
            public BinaryTreeNode RightChild { get; set; }

            ITreeNode<T> ITreeNode<T>.LeftChild => LeftChild;

            ITreeNode<T> ITreeNode<T>.RightChild => RightChild;

            /// <summary>
            /// Инициализирует класс узла бинарного дерева. 
            /// </summary>
            /// <param name="value">Значение.</param>
            /// <param name="leftChild">Левый потомок.</param>
            /// <param name="rightChild">Правый потомок.</param>
            public BinaryTreeNode(T value, BinaryTreeNode leftChild = null, BinaryTreeNode rightChild = null)
            {
                Value = value;
                LeftChild = leftChild;
                RightChild = rightChild;
            }
        }
    }
}

namespace VSU.Collections
{
    public partial class AVLTree<T>
    {
        /// <summary>
        /// Представляет класс узла AVL-Дерева. 
        /// </summary>
        private class AVLTreeNode : ITreeNode<T>
        {
            /// <summary>
            /// Высота поддерева.
            /// </summary>
            public byte Height { get; set; }

            public T Value { get; set;  }

            /// <summary>
            /// Левый ребенок.
            /// </summary>
            public AVLTreeNode LeftChild { get; set; }

            /// <summary>
            /// Правый ребенок.
            /// </summary>
            public AVLTreeNode RightChild { get; set; }

            ITreeNode<T> ITreeNode<T>.LeftChild => LeftChild;

            ITreeNode<T> ITreeNode<T>.RightChild => RightChild;

            /// <summary>
            /// Представляет класс узла AVL-Дерева. 
            /// </summary>
            /// <param name="value">Значение.</param>
            /// <param name="height">Высота.</param>
            /// <param name="leftChild">Левый потомок.</param>
            /// <param name="rightChild">Правый потомок.</param>
            public AVLTreeNode(T value, byte height = 1, AVLTreeNode leftChild = null, AVLTreeNode rightChild = null)
            {
                Height = (byte)(height < 1 ? 0 : height);
                Value = value;
                LeftChild = leftChild;
                RightChild = rightChild;
            }
        }
    }
}

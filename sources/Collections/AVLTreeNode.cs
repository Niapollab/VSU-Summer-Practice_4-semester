namespace VSU.Collections
{
    public partial class AVLTree<T>
    {
        private class AVLTreeNode : ITreeNode<T>
        {
            public byte Height { get; set; }

            public T Value { get; set;  }

            public AVLTreeNode LeftChild { get; set; }

            public AVLTreeNode RightChild { get; set; }

            ITreeNode<T> ITreeNode<T>.LeftChild => LeftChild;

            ITreeNode<T> ITreeNode<T>.RightChild => RightChild;

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

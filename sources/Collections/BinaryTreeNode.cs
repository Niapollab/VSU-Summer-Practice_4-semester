using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSU.Collections
{
    public sealed partial class BinaryTree<T>
    {
        private class BinaryTreeNode : ITreeNode<T>
        {
            public T Value { get; set; }

            public BinaryTreeNode LeftChild { get; set; }

            public BinaryTreeNode RightChild { get; set; }
            ITreeNode<T> ITreeNode<T>.LeftChild => LeftChild;

            ITreeNode<T> ITreeNode<T>.RightChild => RightChild;

            public BinaryTreeNode(T value, BinaryTreeNode leftChild = null, BinaryTreeNode rightChild = null)
            {
                Value = value;
                LeftChild = leftChild;
                RightChild = rightChild;
            }
        }
    }
}

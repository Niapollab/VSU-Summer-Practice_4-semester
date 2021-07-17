namespace VSU.Collections
{
    public interface ITreeNode<T>
    {
        T Value { get; }
        ITreeNode<T> LeftChild { get; }
        ITreeNode<T> RightChild { get; }
    }
}

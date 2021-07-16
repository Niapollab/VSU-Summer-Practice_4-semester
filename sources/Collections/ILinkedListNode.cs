namespace VSU.Collections
{
    public interface ILinkedListNode<T>
    {
        T Value { get; }
        ILinkedListNode<T> Next { get; }
    }
}

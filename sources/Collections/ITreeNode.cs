namespace VSU.Collections
{
    /// <summary>
    /// Представляет интерфейс узла бинарного дерева.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITreeNode<T>
    {
        /// <summary>
        /// Значение.
        /// </summary>
        T Value { get; }

        /// <summary>
        /// Левый ребенок.
        /// </summary>
        ITreeNode<T> LeftChild { get; }

        /// <summary>
        /// Правый ребенок.
        /// </summary>
        ITreeNode<T> RightChild { get; }
    }
}

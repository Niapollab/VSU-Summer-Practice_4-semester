namespace VSU.Collections
{
    /// <summary>
    /// Представляет интерфейс узла линейного списка.
    /// </summary>
    /// <typeparam name="T">Тип элемента.</typeparam>
    public interface ILinkedListNode<T>
    {
        /// <summary>
        /// Значение.
        /// </summary>
        T Value { get; }

        /// <summary>
        /// Следующий узел.
        /// </summary>
        ILinkedListNode<T> Next { get; }
    }
}

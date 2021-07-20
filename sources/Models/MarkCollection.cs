using System.Collections;
using System.Collections.Generic;

namespace VSU.Models
{
    /// <summary>
    /// Представляет коллекцию оценок. 
    /// </summary>
    public class MarkCollection : IReadOnlyCollection<Mark>
    {
        /// <summary>
        /// Оценки.
        /// </summary>
        public Mark[] Marks { get; }

        /// <summary>
        /// Инициализирует коллекцию оценок. 
        /// </summary>
        /// <param name="marks">Оценки.</param>
        public MarkCollection(params Mark[] marks)
            => Marks = marks;

        public Mark this[int index]
            => Marks[index];

        public int Count
            => Marks.Length;

        public IEnumerator<Mark> GetEnumerator()
            => ((IEnumerable<Mark>)Marks).GetEnumerator();

        public override string ToString()
            => string.Join(", ", this);

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}

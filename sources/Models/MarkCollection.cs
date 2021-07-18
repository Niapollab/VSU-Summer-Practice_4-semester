using System.Collections;
using System.Collections.Generic;

namespace VSU.Models
{
    public class MarkCollection : IReadOnlyCollection<Mark>
    {
        public Mark[] Marks { get; }

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

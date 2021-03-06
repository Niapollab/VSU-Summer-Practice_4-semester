using System;

namespace VSU.Models
{
    /// <summary>
    /// Представляет оценку.
    /// </summary>
    public struct Mark : IEquatable<Mark>, IComparable<Mark>
    {
        /// <summary>
        /// Значение оценки.
        /// </summary>
        private readonly byte _value;

        /// <summary>
        /// Инициализирует оценку.
        /// </summary>
        /// <param name="value">Значение оценки.</param>
        public Mark(byte value)
        {
            if (value < 2 || value > 5)
                throw new ArgumentException("Оценка должна быть в диапазоне от 2 до 5.", nameof(value));

            _value = value;
        }

        public int CompareTo(Mark other)
            => _value.CompareTo(other._value);

        public bool Equals(Mark other)
            => _value == other._value;

        public static implicit operator byte(Mark mark)
            => mark._value;

        public static implicit operator int(Mark mark)
            => mark._value;

        public static implicit operator Mark(byte value)
            => new(value);

        public override bool Equals(object obj)
            => obj is Mark mark && Equals(mark);

        public override int GetHashCode()
            => _value.GetHashCode();

        public override string ToString()
            => _value.ToString();

        public static bool operator ==(Mark left, Mark right)
            => left.Equals(right);

        public static bool operator !=(Mark left, Mark right)
            => !(left == right);

        public static bool operator <(Mark left, Mark right)
            => left.CompareTo(right) < 0;

        public static bool operator <=(Mark left, Mark right)
            => left.CompareTo(right) <= 0;

        public static bool operator >(Mark left, Mark right)
            => left.CompareTo(right) > 0;

        public static bool operator >=(Mark left, Mark right)
            => left.CompareTo(right) >= 0;
    }
}

using System;
using System.Linq;

namespace VSU.Models
{
    /// <summary>
    /// Представляет студента.
    /// </summary>
    public class Student : IEquatable<Student>
    {
        /// <summary>
        /// Имя студента.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия студента.
        /// </summary>
        public string SecondName { get; set; }
        /// <summary>
        /// Оценки студента.
        /// </summary>
        public MarkCollection Marks { get; set; }

        /// <summary>
        /// Инициализирует студента.
        /// </summary>
        /// <param name="firstName">Имя студента.</param>
        /// <param name="secondName">Фамилия студента.</param>
        /// <param name="marks">Отчество студента.</param>
        public Student(string firstName, string secondName, params Mark[] marks)
        {
            FirstName = firstName;
            SecondName = secondName;
            Marks = new MarkCollection(marks);
        }

        public bool Equals(Student other)
        {
            if (other != null && FirstName == other.FirstName && SecondName == other.SecondName && Marks.Count == other.Marks.Count)
            {
                for (var i = 0; i < Marks.Count; ++i)
                    if (Marks[i] != other.Marks[i])
                        return false;
                
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
            => Equals(obj as Student);

        public override int GetHashCode()
            => (FirstName, SecondName, Marks.Sum(s => s)).GetHashCode();
    }
}

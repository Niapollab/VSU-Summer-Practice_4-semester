using System;
using System.ComponentModel;
using System.Linq;

namespace VSU.Models
{
    /// <summary>
    /// Представляет студента.
    /// </summary>
    public class Student : IEquatable<Student>, INotifyPropertyChanged
    {
        /// <summary>
        /// Имя студента.
        /// </summary>
        public string FirstName 
        { 
            get => _firstName;
            set 
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
                }
            }
        }
        private string _firstName;

        /// <summary>
        /// Фамилия студента.
        /// </summary>
        public string SecondName 
        {
            get => _secondName;
            set
            {
                if (_secondName != value)
                {
                    _secondName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SecondName)));
                }
            }
        }
        private string _secondName;

        /// <summary>
        /// Оценки студента.
        /// </summary>
        public MarkCollection Marks 
        {
            get => _marks;
            set
            {
                if (_marks.Count != value.Count)
                {
                    _marks = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Marks)));
                }
                else
                {
                    for (var i = 0; i < _marks.Count; ++i)
                        if (_marks[i] != value[i])
                        {
                            _marks = value;
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Marks)));
                        }
                }
            }
        }
        private MarkCollection _marks;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Инициализирует студента.
        /// </summary>
        /// <param name="firstName">Имя студента.</param>
        /// <param name="secondName">Фамилия студента.</param>
        /// <param name="marks">Отчество студента.</param>
        public Student(string firstName, string secondName, MarkCollection markCollection)
        {
            _firstName = firstName;
            _secondName = secondName;
            _marks = markCollection;
        }

        public bool Equals(Student other)
        {
            if (other != null && _firstName == other._firstName && _secondName == other._secondName && _marks.Count == other._marks.Count)
            {
                for (var i = 0; i < _marks.Count; ++i)
                    if (_marks[i] != other._marks[i])
                        return false;
                
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
            => Equals(obj as Student);

        public override int GetHashCode()
            => (_firstName, _secondName, _marks.Sum(s => s)).GetHashCode();
    }
}

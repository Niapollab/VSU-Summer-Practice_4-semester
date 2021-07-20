using System;
using System.Linq;

namespace VSU.Models
{
    /// <summary>
    /// Представляет студента по заданию.
    /// </summary>
    public class TaskStudent : IComparable<TaskStudent>
    {
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string SecondName { get; }

        /// <summary>
        /// Средняя оценка.
        /// </summary>
        public double AverageMark { get; }

        /// <summary>
        /// Инициализирует студента по заданию.
        /// </summary>
        /// <param name="student">Студент.</param>
        public TaskStudent(Student student)
        {
            SecondName = student.SecondName;
            AverageMark = student.Marks.Average(selector => selector);
        }

        public int CompareTo(TaskStudent other)
            => AverageMark.CompareTo(other.AverageMark);
    }
}

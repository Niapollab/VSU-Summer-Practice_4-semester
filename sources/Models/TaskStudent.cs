using System;
using System.Linq;

namespace VSU.Models
{
    public class TaskStudent : IComparable<TaskStudent>
    {
        public string SecondName { get; }
        public double AverageMark { get; }

        public TaskStudent(Student student)
        {
            SecondName = student.SecondName;
            AverageMark = student.Marks.Average(selector => selector);
        }

        public int CompareTo(TaskStudent other)
            => AverageMark.CompareTo(other.AverageMark);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSU.Models
{
    public class TaskStudent : IComparable<TaskStudent>
    {
        public string FirstName { get; }
        public string SecondName { get; }
        public double AverageMark { get; }

        public TaskStudent(Student student)
        {
            FirstName = student.FirstName;
            SecondName = student.SecondName;
            AverageMark = student.Marks.Average(selector => selector);
        }

        public int CompareTo(TaskStudent other)
            => AverageMark.CompareTo(other);
    }
}

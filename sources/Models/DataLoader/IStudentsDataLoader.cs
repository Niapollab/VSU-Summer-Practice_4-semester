using System.Collections.Generic;

namespace VSU.Models.DataLoader
{
    interface IStudentsDataLoader
    {
        IEnumerable<Student> ReadStudents();
        void SaveStudents(IEnumerable<Student> students);
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace VSU.Models.DataLoader
{
    class StudentsJSONDataLoader : IStudentsDataLoader
    {
        private string Filename { get; }

        public StudentsJSONDataLoader(string filename)
        {
            Filename = filename;
        }

        public IEnumerable<Student> ReadStudents()
        {
            if (File.Exists(Filename))
            {
                try
                {
                    return JsonSerializer.Deserialize<Student[]>(File.ReadAllText(Filename));
                }
                catch
                {

                }
            }
            return Array.Empty<Student>();
        }

        public void SaveStudents(IEnumerable<Student> students)
        {
            try
            {
                File.WriteAllText(Filename, JsonSerializer.Serialize(students.ToArray()));
            }
            catch
            {

            }
        }
    }
}

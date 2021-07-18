using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace VSU.Models.DataLoader
{
    public class StudentsJSONDataLoader : IStudentsDataLoader
    {
        private string Filename { get; }

        public StudentsJSONDataLoader(string filename)
            => Filename = filename;

        public async Task<IEnumerable<Student>> ReadStudentsAsync(CancellationToken cancellationToken = default)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new MarksCollectionConverter());
            using var fs = new FileStream(Filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            return await JsonSerializer.DeserializeAsync<Student[]>(fs, options, cancellationToken: cancellationToken);
        }

        public async Task SaveStudentsAsync(IEnumerable<Student> students, CancellationToken cancellationToken = default)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new MarksCollectionConverter());
            using var fs = new FileStream(Filename, FileMode.Create, FileAccess.Write, FileShare.Read);
            await JsonSerializer.SerializeAsync(fs, students.ToArray(), options, cancellationToken: cancellationToken);
        }
    }
}

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace VSU.Models.DataLoader
{
    public interface IStudentsDataLoader
    {
        Task<IEnumerable<Student>> ReadStudentsAsync(CancellationToken cancellationToken = default);
        Task SaveStudentsAsync(IEnumerable<Student> students, CancellationToken cancellationToken = default);
    }
}

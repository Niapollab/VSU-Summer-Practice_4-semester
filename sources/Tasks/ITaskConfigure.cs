using System.Collections.Generic;

namespace VSU.Tasks
{
    public interface ITaskConfigure<T>
    {
        void Configure(IEnumerable<T> collection);
    }
}
using HomeLibraryApp.Entities;

namespace HomeLibraryApp.Repositories
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
        where T : class, IEntity
    {
    }
}

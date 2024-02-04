using HomeLibraryApp.Entities;

namespace HomeLibraryApp.Repositories
{
    public interface IReadRepository<out T>
        where T : class, IEntity
    {
        IEnumerable<T> GetAll();

        T GetById(long id);
    }
}

using HomeLibraryApp.Entities;

namespace HomeLibraryApp.Repositories
{
    public class ListRepository<T> : IRepository<T>
        where T : class, IEntity, new()
    {
        protected readonly List<T> _items = new();

        public void Add(T item)
        {
            item.Id = _items.Count + 1; 
            _items.Add(item);
        }

        public IEnumerable<T> GetAll() => _items.ToList();

        public T GetById(long id) => _items.Single(item => item.Id == id);

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
        }
    }
}

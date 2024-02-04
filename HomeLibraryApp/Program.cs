using HomeLibraryApp.Data;
using HomeLibraryApp.Entities;
using HomeLibraryApp.Repositories;

var bookRepository = new SqlRepository<Book>(new HomeLibraryAppDbContext());

bookRepository.Add(new Book { Title = "Mały Książę"});
bookRepository.Add(new Book { Title = "Cień wiatru"});
bookRepository.Add(new Book { Title = "Władca Pierścieni"});

GetBookById(bookRepository);

static void GetBookById(IReadRepository<IEntity> bookRepository)
{
    var book = bookRepository.GetById(2);
    Console.WriteLine(book);
}

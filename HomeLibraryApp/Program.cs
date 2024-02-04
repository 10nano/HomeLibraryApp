using HomeLibraryApp.Data;
using HomeLibraryApp.Entities;
using HomeLibraryApp.Repositories;

var bookRepository = new SqlRepository<Book>(new HomeLibraryAppDbContext());

AddBooks(bookRepository);
AddeBooks(bookRepository);
WriteAllToConsole(bookRepository);

static void AddBooks(IRepository<Book> bookRepository)
{
    bookRepository.Add(new Book { Title = "Mały Książę" });
    bookRepository.Add(new Book { Title = "Cień wiatru" });
    bookRepository.Add(new Book { Title = "Władca Pierścieni" });
    bookRepository.Add(new Book { Title = "Z goryczy soli moja radość" });
    bookRepository.Save();
}

static void AddeBooks(IWriteRepository<EBook> ebookRepository)
{
    ebookRepository.Add(new EBook { Title = "Atomowe nawyki" });
    ebookRepository.Add(new EBook { Title = "Życie Pi" });
    ebookRepository.Add(new EBook { Title = "Z goryczy soli moja radość" });
    ebookRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}
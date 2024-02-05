using HomeLibraryApp.Data;
using HomeLibraryApp.Entities;
using HomeLibraryApp.Repositories;

var bookRepository = new SqlRepository<Books>(new HomeLibraryAppDbContext());

AddBooks(bookRepository);
AddeBooks(bookRepository);
WriteAllToConsole(bookRepository);

static void AddBooks(IRepository<Books> bookRepository)
{
    bookRepository.Add(new Books { Title = "Mały Książę" });
    bookRepository.Add(new Books { Title = "Cień wiatru" });
    bookRepository.Add(new Books { Title = "Władca Pierścieni" });
    bookRepository.Add(new Books { Title = "Z goryczy soli moja radość" });
    bookRepository.Save();
}

static void AddeBooks(IWriteRepository<EBooks> ebookRepository)
{
    ebookRepository.Add(new EBooks { Title = "Atomowe nawyki" });
    ebookRepository.Add(new EBooks { Title = "Życie Pi" });
    ebookRepository.Add(new EBooks { Title = "Z goryczy soli moja radość" });
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
using Microsoft.EntityFrameworkCore;
using HomeLibraryApp.Entities;

namespace HomeLibraryApp.Data
{
    internal class HomeLibraryAppDbContext : DbContext
    {
        public DbSet<Book> Book => Set<Book>();

        public DbSet<CDrom> Crom => Set<CDrom>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("HomeLibDb");
        }
    }
}
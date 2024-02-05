using Microsoft.EntityFrameworkCore;
using HomeLibraryApp.Entities;

namespace HomeLibraryApp.Data
{
    internal class HomeLibraryAppDbContext : DbContext
    {
        public DbSet<Book> Books => Set<Book>();

        // public DbSet<CDroms> CDroms => Set<CDroms>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("HomeLibDb");
        }
    }
}
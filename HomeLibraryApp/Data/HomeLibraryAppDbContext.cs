using Microsoft.EntityFrameworkCore;
using HomeLibraryApp.Entities;

namespace HomeLibraryApp.Data
{
    internal class HomeLibraryAppDbContext : DbContext
    {
        public DbSet<Books> Book => Set<Books>();

        public DbSet<CDroms> Crom => Set<CDroms>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("HomeLibDb");
        }
    }
}
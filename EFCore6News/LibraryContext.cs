using EFCore6News.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore6News
{
    public class LibraryContext : DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Library;Trusted_Connection=True");
        }
    }
}
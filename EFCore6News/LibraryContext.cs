using System;
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

        #region Conventions

        // Antes
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //            .Entity<Book>()
        //            .Property(p => p.Title)
        //            .HasMaxLength(100);
        //}

        // En .NET 6
        //protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        //{
        //    configurationBuilder.Properties<string>().HaveMaxLength(100);
        //}

        #endregion

        #region New attributes

        // ---> Go to Book entity!

        #endregion

        #region Column ordering

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //        .Entity<Book>(
        //           entityBuilder =>
        //           {
        //               entityBuilder.Property(e => e.Id).HasColumnOrder(1);
        //               entityBuilder.Property(e => e.Pages).HasColumnOrder(2);
        //               entityBuilder.Property(e => e.Title).HasColumnOrder(3);
        //           });
        //}

        #endregion

        #region Temporal tables

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configurando una temporal table
        //    modelBuilder
        //        .Entity<Book>()
        //        .ToTable("Employees", b => b.IsTemporal());

        //    // Personalizando columnas
        //    modelBuilder
        //        .Entity<Book>()
        //        .ToTable(
        //            "Books",
        //                b => b.IsTemporal(
        //                    b =>
        //                    {
        //                        b.HasPeriodStart("ValidFrom"); // --> PeriodStart
        //                        b.HasPeriodEnd("ValidTo"); // --> PeriodEnd
        //                        b.UseHistoryTable("BooksTimelineData");
        //                    }));

        //    var bookList = Books.ToList();
        //    foreach (var book in bookList)
        //    {
        //        var bookEntry = Entry(book);
        //        var validFrom = bookEntry.Property<DateTime>("ValidFrom").CurrentValue;
        //        var validTo = bookEntry.Property<DateTime>("ValidTo").CurrentValue;

        //        Console.WriteLine($"Book - {book.Title} - valid from {validFrom} to {validTo}");

        //        // Resultado:
        //        //        Book - Dune - valid from 1/22/2022 4:38:58 PM to 12/31/9999 11:59:59 PM
        //        //        Book - Eragon - valid from 1/22/2022 4:38:58 PM to 12/31/9999 11:59:59 PM
        //        //        Book - Ciudad de huesos - valid from 1/22/2022 4:38:58 PM to 12/31/9999 11:59:59 PM
        //    }
        //}

        #endregion
    }
}
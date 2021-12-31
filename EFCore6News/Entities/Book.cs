using Microsoft.EntityFrameworkCore;

namespace EFCore6News.Entities
{
    //[EntityTypeConfiguration(typeof(BookConfiguration))]
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }

        public Genre Genre { get; set; }

        //[Precision(10, 2)]
        //public decimal Price { get; set; }
    }
}
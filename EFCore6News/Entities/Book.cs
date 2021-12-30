namespace EFCore6News.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }

        public Genre Genre { get; set; }
    }
}
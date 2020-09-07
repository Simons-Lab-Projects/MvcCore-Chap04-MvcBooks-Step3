namespace MvcBooks.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public int PubYear { get; set; }

        public Book(int bid, int cid, string title, int year)
        {
            BookId = bid;
            CategoryId = cid;
            Title = title;
            PubYear = year;
        }

        public Book()
        {
        }
    }
}

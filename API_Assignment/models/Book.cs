namespace API_Assignment.models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

        public string Author { get; set; }

        public int Price { get; set; }

        public string Lang { get; set; }

        public DateTime ReleaseDate { get; set; }

    }
}

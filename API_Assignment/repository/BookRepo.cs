using API_Assignment.models;

namespace API_Assignment.repository
{
    public class BookRepo : IBookRepo
    {

        static List<Book> books = new List<Book>();

        public void AddBook(Book b)
        {
            books.Add(b);
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await Task.Run(() =>
            {
                return books.ToList();
            });
        }

        public async Task<List<Book>> GetBookByAuthor(string Author)
        {

            return await Task.Run(() =>
            {
                List<Book> SelectedBoook = new List<Book>();
                foreach (Book book in books)
                {
                    if (book.Author == Author)
                    {
                        SelectedBoook.Add(book);
                    }
                }

                return SelectedBoook.ToList();

            });

            
        }

        public async Task<List<Book>> GetBookByLang(string Lang)
        {

            return await Task.Run(() =>
            {
                List<Book> SelectedBoook = new List<Book>();
                foreach (Book book in books)
                {
                    if (book.Lang == Lang)
                    {
                        SelectedBoook.Add(book);
                    }
                }

                return SelectedBoook.ToList();
            });

           
        }


        public async Task<List<Book>> GetBookByYear(int year)
        {

            return await Task.Run(() =>
            {
                List<Book> SelectedBoook = new List<Book>();
                foreach (Book book in books)
                {
                    if (book.ReleaseDate.Year == year)
                    {
                        SelectedBoook.Add(book);
                    }
                }

                return SelectedBoook.ToList();
            });

            
        }

        public void DeleteBook(int bookId)
        {
            for(int i = 0; i < books.Count; i++)
            {
                if(books[i].BookId == bookId)
                    books.RemoveAt(i);
            }
        }



    }
}

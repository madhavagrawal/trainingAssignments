using API_Assignment.models;

namespace API_Assignment.repository
{
    public interface IBookRepo
    {
        void AddBook(Book b);

        Task<List<Book>> GetAllBooks();

        Task<List<Book>> GetBookByAuthor(string Author);

        Task<List<Book>> GetBookByLang(string lang);

        Task<List<Book>> GetBookByYear(int year);

        //void EditBook(Book book);

        void DeleteBook(int bookId);


        
    }
}

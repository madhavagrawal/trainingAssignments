using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_Assignment.models;
using API_Assignment.repository;
namespace API_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookRepo bookRepository;
        public BookController()
        {
            this.bookRepository = new BookRepo();
            
        }

        [HttpPost, Route("AddBook")]
        public IActionResult AddBook(Book b)
        {
            bookRepository.AddBook(b);
            return StatusCode(200, b);
        }


        [HttpGet, Route("GetAllBooks")]

        public async Task<IActionResult> GetAllBooks()
        {
            try
            {
                List<Book> books = await bookRepository.GetAllBooks();
                return StatusCode(200, books);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);  
            }
        }

        [HttpGet, Route("GetBookByAuthor/{Author}")]

        public async Task<IActionResult> GetBookByAuthor(string Author)
        {
            try
            {
                List<Book> b = await bookRepository.GetBookByAuthor(Author);
                return StatusCode(200, b);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet, Route("GetBookByLang/{Lang}")]

        public async Task<IActionResult> GetBookByLang(string Lang)
        {
            try
            {
                List<Book> b = await bookRepository.GetBookByLang(Lang);
                return StatusCode(200, b);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        

        [HttpGet, Route("GetBookByYear/{year}")]

        public async Task<IActionResult> GetBookByYear(int year)
        {
            try
            {
                List<Book> b = await bookRepository.GetBookByYear(year);
                return StatusCode(200, b);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete, Route("DeleteBook/{bookId}")]
        public IActionResult DeleteBook(int bookId)
        {
            bookRepository.DeleteBook(bookId);
            return StatusCode(200, "Book Deleted");
        }

    }
}

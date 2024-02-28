using BookStore.Core.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksServices _bookService;

        public BooksController(IBooksServices booksService)
        {
            _bookService = booksService;    
        }

        [HttpGet]
        public async Task<ActionResult<List<BookResponce>>> GetBooks()
        {
            var books = await _bookService.GetAllBooks();

            var responce = books.Select(b => new BookResponce(b.Id, b.Title, b.Description, b.Price));
            
            
            return Ok(responce);

        }

       
    }
}

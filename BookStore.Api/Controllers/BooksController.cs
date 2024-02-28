using BookStore.Api.Contracts;
using BookStore.Core.Abstractions;
using BookStore.Core.Models;
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
        [HttpPost]
        public async Task<ActionResult<Guid>> CreateBook([FromBody] BookRequest request)
        {

            var (book, error) = Book.Create(
                Guid.NewGuid(),
                request.Title,
                request.Description,
                request.Price);

            if (!string.IsNullOrEmpty(error))
            {
                return BadRequest(error);
            }

            await _bookService.CreateBook(book);

            return Ok(request);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Guid>> UpdateBooks(Guid id, [FromBody] BookRequest request)
        {
            var bookId = await _bookService.UpdateBook(id, request.Title, request.Description, request.Price);

            return Ok(bookId);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Guid>> DeleteBooks(Guid id)
        {        

            return Ok(await _bookService.DeleteBook(id));
        }

    }
}

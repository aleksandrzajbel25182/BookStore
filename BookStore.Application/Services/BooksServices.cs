using BookStore.Core.Models;
using BookStore.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
    public class BooksServices
    {
        private readonly IBooksRepository _booksRepository;

        public BooksServices(IBooksRepository booksRepository)
        {

            _booksRepository = booksRepository;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _booksRepository.Get();
        }
    }
}

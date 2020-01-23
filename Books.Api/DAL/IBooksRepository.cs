using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Books.Api.Entities;

namespace Books.Api.DAL
{
    public interface IBooksRepository
    {
        Task<IEnumerable<Book>> GetBooksAsync();
        Task<Book> GetBook(Guid id);
    }
}
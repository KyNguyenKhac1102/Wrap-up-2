

using System.Collections.Generic;
using System.Linq;
using WrapUp2.DataAccess;
using WrapUp2.Models;

namespace WrapUp2.Services
{
    public class BookService : IService.IBookService
    {
        private readonly LibraryContext _libraryContext;
        public BookService(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        public List<Book> Create(BookDTO bookDTO)
        {
            var newBook = new Book
            {
                BookName = bookDTO.BookName,
                Genre = bookDTO.Genre,
                Country = bookDTO.Country,
                Series = bookDTO.Series,
                BorrowPrice = bookDTO.BorrowPrice,
            };
            _libraryContext.Books.Add(newBook);
            _libraryContext.SaveChanges();

            return _libraryContext.Books.ToList();
        }

        public List<Book> Delete(int BookId)
        {
            var deleteBook = _libraryContext.Clients.Find(BookId);
            _libraryContext.Remove(deleteBook);
            _libraryContext.SaveChanges();

            return _libraryContext.Books.ToList();
        }

        public List<Book> getAllBook()
        {
            return _libraryContext.Books.ToList();
        }

        public List<Book> Update(int BookId, BookDTO bookDTO)
        {
            var BookUpdate = _libraryContext.Books.Find(BookId);
            BookUpdate.BookName = bookDTO.BookName;
            BookUpdate.Genre = bookDTO.Genre;
            BookUpdate.Country = bookDTO.Country;
            BookUpdate.Series = bookDTO.Series;
            BookUpdate.BorrowPrice = bookDTO.BorrowPrice;

            _libraryContext.SaveChanges();
            return _libraryContext.Books.ToList();
        }
    }
}
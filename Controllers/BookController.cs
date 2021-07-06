using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WrapUp2.Models;
using WrapUp2.Services;

namespace WrapUp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {

        private readonly IService.IBookService _bookService;

        public BookController(IService.IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public List<Book> Book()
        {
            return _bookService.getAllBook();
        }
        [HttpPost]
        public List<Book> Book(BookDTO bookDTO)
        {
            _bookService.Create(bookDTO);
            return _bookService.getAllBook();
        }
        [HttpPut("{id}")]
        public List<Book> Book(int id, BookDTO bookDTO)
        {
            return _bookService.Update(id, bookDTO);
        }

        [HttpDelete("{id}")]
        public List<Book> Book(int id)
        {
            _bookService.Delete(id);
            return _bookService.getAllBook();
        }
    }
}

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
    public class AuthorController : ControllerBase
    {

        private readonly IService.IAuthorService _authorService;

        public AuthorController(IService.IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public List<Author> Author()
        {
            return _authorService.getAllAuthor();
        }
        [HttpPost]
        public List<Author> Author(AuthorDTO authorDTO)
        {
            _authorService.Create(authorDTO);
            return _authorService.getAllAuthor();
        }
        [HttpPut("{id}")]
        public List<Author> Author(int id, AuthorDTO authorDTO)
        {
            return _authorService.Update(id, authorDTO);
        }

        [HttpDelete("{id}")]
        public List<Author> Author(int id)
        {
            _authorService.Delete(id);
            return _authorService.getAllAuthor();
        }
    }
}

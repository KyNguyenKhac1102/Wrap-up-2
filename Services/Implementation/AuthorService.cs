

using System.Collections.Generic;
using WrapUp2.DataAccess;
using WrapUp2.Models;
using System.Linq;

namespace WrapUp2.Services{
    public class AuthorService : IService.IAuthorService
    {
        private readonly LibraryContext _libraryContext;
        public AuthorService(LibraryContext libraryContext){
            _libraryContext = libraryContext;
        }
        public List<Author> Create(AuthorDTO authorDTO)
        {
            var newAuthor = new Author
            {
                FristName = authorDTO.FristName,
                LastName = authorDTO.LastName,
                DateOfBirth = authorDTO.DateOfBirth,
            };
            _libraryContext.Authors.Add(newAuthor);
            _libraryContext.SaveChanges();

            return _libraryContext.Authors.ToList();
        }

        public List<Author> Delete(int AuthorId)
        {
            var deleteAuthor = _libraryContext.Authors.Find(AuthorId);
            _libraryContext.Remove(deleteAuthor);
            _libraryContext.SaveChanges();

            return _libraryContext.Authors.ToList();
        }

        public List<Author> getAllAuthor()
        {
            return _libraryContext.Authors.ToList();
        }

        public List<Author> Update(int AuthorId, AuthorDTO AuthorDTO)
        {
            var authorUpdate = _libraryContext.Authors.Find(AuthorId);
            authorUpdate.FristName = AuthorDTO.FristName;
            authorUpdate.LastName = AuthorDTO.LastName;
            authorUpdate.DateOfBirth = AuthorDTO.DateOfBirth;

            _libraryContext.SaveChanges();
            return _libraryContext.Authors.ToList();
            
        }
    }
}
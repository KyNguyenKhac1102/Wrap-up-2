
using System.Collections.Generic;
using WrapUp2.Models;

namespace WrapUp2.Services
{
    public interface IService
    {
        interface IAuthorService
        {
            List<Author> getAllAuthor();
            List<Author> Create(AuthorDTO authorDTO);
            List<Author> Update(int AuthorId, AuthorDTO AuthorDTO);
            List<Author> Delete(int AuthorId);
        }

        interface IBookService
        {
            List<Book> getAllBook();
            List<Book> Create(BookDTO bookDTO);
            List<Book> Update(int BookId, BookDTO bookDTO);
            List<Book> Delete(int BookId);
        }
        interface IClientService
        {
            List<Client> getAllClient();
            List<Client> Create(ClientDTO clientDTO);
            List<Client> Update(int ClientId, ClientDTO ClientDTO);
            List<Client> Delete(int ClientId);
        }
    }


}
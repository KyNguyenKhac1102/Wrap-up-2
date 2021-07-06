

using System.Collections.Generic;
using System.Linq;
using WrapUp2.DataAccess;
using WrapUp2.Models;

namespace WrapUp2.Services
{
    public class ClientService : IService.IClientService
    {
        private readonly LibraryContext _libraryContext;
        public ClientService(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        public List<Client> Create(ClientDTO clientDTO)
        {
            var newClient = new Client
            {
                ClientName = clientDTO.ClientName,
                Address = clientDTO.Address,
                Email = clientDTO.Email,
            };
            _libraryContext.Clients.Add(newClient);
            _libraryContext.SaveChanges();

            return _libraryContext.Clients.ToList();
        }

        public List<Client> Delete(int ClientId)
        {
            var deleteClient = _libraryContext.Clients.Find(ClientId);
            _libraryContext.Remove(deleteClient);
            _libraryContext.SaveChanges();

            return _libraryContext.Clients.ToList();
        }

        public List<Client> getAllClient()
        {
            return _libraryContext.Clients.ToList();
        }

        public List<Client> Update(int ClientId, ClientDTO ClientDTO)
        {
            var clientUpdate = _libraryContext.Clients.Find(ClientId);
            clientUpdate.ClientName = ClientDTO.ClientName;
            clientUpdate.Address = ClientDTO.Address;
            clientUpdate.Email = ClientDTO.Email;

            _libraryContext.SaveChanges();
            return _libraryContext.Clients.ToList();
        }
    }
}
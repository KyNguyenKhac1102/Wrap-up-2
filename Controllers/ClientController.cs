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
    public class ClientController : ControllerBase
    {

        private readonly IService.IClientService _clientService;

        public ClientController(IService.IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public List<Client> Client()
        {
            return _clientService.getAllClient();
        }
        [HttpPost]
        public List<Client> Client(ClientDTO clientDTO)
        {
            _clientService.Create(clientDTO);
            return _clientService.getAllClient();
        }
        [HttpPut("{id}")]
        public List<Client> Client(int id, ClientDTO clientDTO)
        {
            return _clientService.Update(id, clientDTO);
        }

        [HttpDelete("{id}")]
        public List<Client> Client(int id)
        {
            _clientService.Delete(id);
            return _clientService.getAllClient();
        }
    }
}

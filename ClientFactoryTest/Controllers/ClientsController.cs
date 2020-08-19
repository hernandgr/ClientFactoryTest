using ClientFactoryTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientFactoryTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientFactory _clientFactory;

        public ClientsController(IClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet]
        [Route("{secret}")]
        public IActionResult Get(string secret)
        {
            var client = _clientFactory.GetClient(secret);

            return Ok(client);
        }
    }
}
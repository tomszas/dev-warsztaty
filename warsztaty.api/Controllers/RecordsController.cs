using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using warsztaty.messages.Commands;
using RawRabbit;
using warsztaty.API.Storage;

namespace warsztaty.API.Controllers
{
    [Route("[controller]")]
    public class RecordsController : Controller
    {
        private readonly IBusClient _busClient;
        private readonly IStorage _storage;

        public RecordsController(IBusClient busClient, IStorage storage)
        {
            _busClient = busClient;
            _storage = storage;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var elements = _storage.GetAll();
            return Json(elements);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateRecord command)
        {
            await _busClient.PublishAsync(command);
            return Accepted(); // 202
        }
    }
}

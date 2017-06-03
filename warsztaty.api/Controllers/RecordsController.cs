using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using warsztaty.messages.Commands;
using RawRabbit;

namespace warsztaty.API.Controllers
{
    [Route("[controller]")]
    public class RecordsController : Controller
    {
        private readonly IBusClient _busClient;

        public RecordsController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateRecord command)
        {
            await _busClient.PublishAsync(command);
            return Accepted(); // 202
        }
    }
}

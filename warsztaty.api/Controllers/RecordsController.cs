using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using warsztaty.messages.Commands;

namespace warsztaty.API.Controllers
{
    [Route("[controller]")]
    public class RecordsController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateRecord command)
        {
            return Accepted(); // 202
        }
    }
}

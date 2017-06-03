using Microsoft.AspNetCore.Mvc;

namespace warsztaty.API.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get() => Content("Hello from warsztaty api :)");
    }
}

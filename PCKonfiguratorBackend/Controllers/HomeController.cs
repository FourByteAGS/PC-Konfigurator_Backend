using Microsoft.AspNetCore.Mvc;

namespace PCKonfiguratorBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}

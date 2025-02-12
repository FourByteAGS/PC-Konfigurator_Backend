using Microsoft.AspNetCore.Mvc;

namespace PCKonfiguratorBackend.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            return Ok("Hallo Welt");
        }
    }
}
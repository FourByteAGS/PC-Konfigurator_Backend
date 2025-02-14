using Microsoft.AspNetCore.Mvc;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        public readonly IAuthService _authService;
        public readonly List<ProductCollection> _productCollection;

        public AuthController(IAuthService authService,List<ProductCollection> productCollection)
        {
            _authService = authService;
            _productCollection = productCollection;
        }

        [HttpGet("GetToken")]
        public IActionResult GetToken() => Ok(_authService.GetNewToken());

        [HttpGet("ValidateToken")]
        public IActionResult ValidateToken(Guid token)
        {
            if (_authService.ValidateToken(token))
            {
                return Ok();
            }
            return NotFound();
        }

    }
}

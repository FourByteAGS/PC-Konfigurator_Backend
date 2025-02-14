using Microsoft.AspNetCore.Mvc;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        public readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
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

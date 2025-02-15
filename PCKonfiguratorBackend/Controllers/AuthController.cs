using Microsoft.AspNetCore.Mvc;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        public readonly IAuthRepository AuthRepository;
        public readonly List<ProductCollection> _productCollection;

        public AuthController(IAuthRepository authRepository,List<ProductCollection> productCollection)
        {
            AuthRepository = authRepository;
            _productCollection = productCollection;
        }

        [HttpGet("GetToken")]
        public IActionResult GetToken() => Ok(AuthRepository.GetNewToken());

        [HttpGet("ValidateToken")]
        public IActionResult ValidateToken(Guid token)
        {
            if (AuthRepository.ValidateToken(token))
            {
                return Ok();
            }
            return NotFound();
        }

    }
}

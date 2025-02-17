using Microsoft.AspNetCore.Mvc;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        public readonly IAuthRepository authRepository;
        public readonly List<ProductCollection> _productCollection;

        public AuthController(IAuthRepository authRepository,List<ProductCollection> productCollection)
        {
            this.authRepository = authRepository;
            _productCollection = productCollection;
        }

        [HttpGet("gettoken")]
        public IActionResult GetToken() => Ok(authRepository.GetNewToken());

        [HttpGet("validatetoken")]
        public IActionResult ValidateToken(Guid token)
        {
            if (authRepository.ValidateToken(token))
            {
                return Ok();
            }
            return NotFound();
        }

    }
}

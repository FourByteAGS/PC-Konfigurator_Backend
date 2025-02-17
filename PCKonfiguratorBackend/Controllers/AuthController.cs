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
        public readonly List<ProductCollection> _productCollections;

        public AuthController(IAuthRepository authRepository,List<ProductCollection> productCollections)
        {
            this.authRepository = authRepository;
            _productCollections = productCollections;
        }

        [HttpGet("gettoken")]
        public IActionResult GetToken()
        {
            var token = authRepository.GetNewToken();
            
            if(!_productCollections.Any()|| _productCollections.Where(x => x.token == token).Any())
                _productCollections.Add(new ProductCollection(token));
            
            return Ok(token);
        }

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

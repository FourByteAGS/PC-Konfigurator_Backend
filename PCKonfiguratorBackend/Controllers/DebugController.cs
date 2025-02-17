using Microsoft.AspNetCore.Mvc;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Controllers
{
    [ApiController]
    [Route("api/debug")]
    public class DebugController : ControllerBase
    {
        public readonly IAuthRepository _authRepository;
        public readonly List<ProductCollection> _productCollection;

        public DebugController(IAuthRepository authRepository, List<ProductCollection> productCollection)
        {
            this._authRepository = authRepository;
            _productCollection = productCollection;
        }

        [HttpGet("allproductcollection")]
        public IActionResult AllProductCollection()
        {
            return Ok(_productCollection.ToJson());
        }
    }
}

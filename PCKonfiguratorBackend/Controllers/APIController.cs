using Microsoft.AspNetCore.Mvc;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Controllers
{
    [ApiController]
    [Route("api")]
    public class APIController : ControllerBase
    {
        public readonly IAuthRepository authRepository;
        public readonly List<ProductCollection> _productCollection;

        public APIController(IAuthRepository authRepository, List<ProductCollection> productCollection)
        {
            this.authRepository = authRepository;
            _productCollection = productCollection;
        }

        [HttpGet("getallselected")]
        public IActionResult GetAllSelected(Guid token)
        {


            var components = new[] { "Tower", "CPU", "Mainboard", "CPUFan", "RAM", "GPU", "Storage", "Fan", "PSU" };



            var product = _productCollection.FirstOrDefault(x => x.token == token);
            if (product == null)
                return NotFound();

            var componentMappings = new Dictionary<string, string>
{
                { "Tower","1"},
                { "CPU","2" },
                { "Mainboard", "3" },
                { "CPUFan", "4" },
                { "RAM", "5" },
                { "GPU", "6" },
                { "Storage", "7" },
                { "Fan", "8" },
                { "PSU", "9" }
};

            var result = componentMappings.ToDictionary(
                kvp => kvp.Value,
                kvp =>
                {
                    var prop = product.GetType().GetProperty($"selected{kvp.Key}")?.GetValue(product);
                    return prop != null ? new
                    {
                        id = prop.GetType().GetProperty("id")?.GetValue(prop),
                        name = prop.GetType().GetProperty("name")?.GetValue(prop),
                        price = prop.GetType().GetProperty("price")?.GetValue(prop)
                    } : null;
                }
            );


            return Ok(result.ToJson());

        }
    }
}

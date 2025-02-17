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
                { "Tower","Gehäuse"},
                { "CPU","Prozessor" },
                { "Mainboard", "Mainboard" },
                { "CPUFan", "Prozessorkühler" },
                { "RAM", "Arbeitsspeicher" },
                { "GPU", "Grafikkarte" },
                { "Storage", "Datenträger" },
                { "Fan", "Gehäuselüfter" },
                { "PSU", "Netzteil" }
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

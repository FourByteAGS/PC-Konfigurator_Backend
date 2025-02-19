using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
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
            var product = _productCollection.FirstOrDefault(x => x.token == token);

            var componentMappings = new Dictionary<string, string>
            {
                { "Tower", "Gehäuse" },
                { "CPU", "Prozessor" },
                { "Mainboard", "Mainboard" },
                { "CPUFan", "Prozessorkühler" },
                { "RAM", "Arbeitsspeicher" },
                { "GPU", "Grafikkarte" },
                { "Storage", "Datenträger" },
                { "Fan", "Gehäuselüfter" },
                { "PSU", "Netzteil" }
            };

            var result = componentMappings.Select(kvp =>
            {
                // Falls kein Produkt existiert oder die Eigenschaft nicht vorhanden ist → Dummy-Werte zurückgeben
                if (product == null)
                {
                    return new
                    {
                        category = kvp.Value,
                        id = "",
                        name = "",
                        price = "",
                        image = ""
                    };
                }

                var propInfo = product.GetType().GetProperty($"selected{kvp.Key}");
                if (propInfo == null || propInfo.GetValue(product) == null)
                {
                    return new
                    {
                        category = kvp.Value,
                        id = "",
                        name = "",
                        price = "",
                        image = ""
                    };
                }

                var prop = propInfo.GetValue(product);

                return new
                {
                    category = kvp.Value,
                    id = prop.GetType().GetProperty("id")?.GetValue(prop) as string ?? "",
                    name = prop.GetType().GetProperty("name")?.GetValue(prop) as string ?? "",
                    price = prop.GetType().GetProperty("price")?.GetValue(prop)?.ToString() ?? "",
                    image = prop.GetType().GetProperty("image")?.GetValue(prop) as string ?? ""
                };
            }).ToArray();

            return Ok(result);
        }
    }
}

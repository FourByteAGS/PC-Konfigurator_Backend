using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/mainboard")]
public class MainboardController : ControllerBase, IComponentRepository
{
    public readonly IAuthRepository _authService;
    public readonly ApplicationDbContext _db;
    public readonly List<ProductCollection> _productCollections;

    public MainboardController(IAuthRepository authRepository, ApplicationDbContext db, List<ProductCollection> productCollections)
    {
        _authService = authRepository;
        _db = db;
        _productCollections = productCollections;
    }

    [HttpGet("getall")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.Mainboards.Include(i => i.mainboardSpecifications).Include(i => i.dimensions).ToJson());
    }

    [HttpGet("setcomponent")]
    public IActionResult SetComponent(Guid token, Guid componentId)
    {
        if (!_authService.ValidateToken(token))
        {
            return Unauthorized();
        }

        var mainboard = _db.Mainboards.Include(i => i.mainboardSpecifications).Include(i => i.dimensions).FirstOrDefault(i => i.id == componentId);
        _productCollections.Where(x => x.token == token).FirstOrDefault().selectedMainboard = mainboard;
        return Ok();
    }

    [HttpGet("getcompatible")]
    public IActionResult GetCompatible(Guid token)
    {
        if (_authService.ValidateToken(token))
        {
            var selectedProduct = _productCollections.FirstOrDefault(x => x.token == token);

            if (selectedProduct?.selectedTower == null|| selectedProduct?.selectedCPU == null)
            {
                return BadRequest("Kein passender Tower,CPU für das Token gefunden.");
            }

            var compatibleMainboards = _db.Mainboards
                .Include(i => i.mainboardSpecifications)
                .Include(i => i.dimensions)
                .Where(i => i.mainboardSpecifications.formFactor == selectedProduct.selectedTower.formFactor&&i.mainboardSpecifications.socket == selectedProduct.selectedCPU.cpuSpecification.socket)
                .ToList();

            if (compatibleMainboards == null || !compatibleMainboards.Any())
            {
                return NotFound("Keine passenden Mainboards gefunden.");
            }

            return Ok(compatibleMainboards.ToJson());
        }

        return Unauthorized();
    }


    [HttpGet("getselected")]
    public IActionResult GetSelected(Guid token)
    {
        var t = _productCollections.Where(x => x.token == token).First().selectedMainboard;
        if (t == null)
            return NotFound();
        return Ok(new Sitebar(t.id, t.name, t.price).ToJson());
    }
}
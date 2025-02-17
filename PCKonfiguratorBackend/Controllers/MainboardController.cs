using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;
using PCKonfiguratorBackend.Service;

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

    [HttpGet("GetAll")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.Mainboards.Include(i => i.mainboardSpecifications).Include(i => i.dimensions).ToJson());
    }

    [HttpGet("SetComponentAsSelected")]
    public IActionResult SetComponentAsSelected(Guid token, Guid componentId)
    {
        if (!_authService.ValidateToken(token))
        {
            return Unauthorized();
        }

        var mainboard = _db.Mainboards.Include(i=>i.mainboardSpecifications).Include(i=>i.dimensions).FirstOrDefault(i => i.id == componentId);
        _productCollections.Where(x => x.token == token).FirstOrDefault().selectedMainboard = mainboard;
        return Ok();
    }

    [HttpGet("GetMainboardByTower")]
    public IActionResult GetMainboardByTower(Guid token)
    {
        if (_authService.ValidateToken(token))
        {
            var selectedProduct = _productCollections.FirstOrDefault(x => x.token == token);

            if (selectedProduct?.selectedTower == null)
            {
                return BadRequest("Kein passender Tower für das Token gefunden.");
            }

            var compatibleMainboards = _db.Mainboards
                .Include(i => i.mainboardSpecifications)
                .Include(i => i.dimensions)
                .Where(i => i.mainboardSpecifications.formFactor == selectedProduct.selectedTower.formFactor)
                .ToList();

            if (compatibleMainboards == null || !compatibleMainboards.Any())
            {
                return NotFound("Keine passenden Mainboards gefunden.");
            }

            return Ok(compatibleMainboards.ToJson());
        }

        return Unauthorized();
    }
} 
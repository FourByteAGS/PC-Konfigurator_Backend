using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;
using PCKonfiguratorBackend.Service;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/gpu")]
public class GpuController : ControllerBase, IComponentRepository
{
    public readonly IAuthRepository _authService;
    public readonly ApplicationDbContext _db;
    public readonly List<ProductCollection> _productCollections;

    public GpuController(IAuthRepository authRepository, ApplicationDbContext db, List<ProductCollection> productCollections)
    {
        _authService = authRepository;
        _db = db;
        _productCollections = productCollections;
    }

    [HttpGet("getall")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.GPUs.Include(i => i.gpuSpecifications).Include(i => i.dimensions).ToJson());
    }

    [HttpGet("setcomponent")]
    public IActionResult SetComponent(Guid token, Guid componentId)
    {
        if (!_authService.ValidateToken(token))
        {
            return Unauthorized();
        }

        var gpu = _db.GPUs.Include(i => i.gpuSpecifications).Include(i => i.dimensions).FirstOrDefault(i => i.id == componentId);
        _productCollections.Where(x => x.token == token).FirstOrDefault().selectedGPU = gpu;
        return Ok();
    }

    [HttpGet("getcompatible")]
    public IActionResult GetCompatible(Guid token)
    {
        if (_authService.ValidateToken(token))
        {
            var selectedProduct = _productCollections.FirstOrDefault(x => x.token == token);

            if (selectedProduct?.selectedTower == null)
            {
                return BadRequest("Kein passender Tower für das Token gefunden.");
            }

            var compatibleMainboards = _db.GPUs
                .Include(i => i.gpuSpecifications)
                .Include(i => i.dimensions)
                .Where(i => i.dimensions.width == selectedProduct.selectedTower.towerCompatibility.maxGpuLenght)
                .ToList();

            if (compatibleMainboards == null || !compatibleMainboards.Any())
            {
                return NotFound("Keine passenden GPU gefunden.");
            }

            return Ok(compatibleMainboards.ToJson());
        }

        return Unauthorized();
    }


    [HttpGet("getselected")]
    public IActionResult GetSelected(Guid token)
    {
        var t = _productCollections.Where(x => x.token == token).First().selectedGPU;
        return Ok(new Sitebar(t.id, t.name, t.price).ToJson());
    }
} 
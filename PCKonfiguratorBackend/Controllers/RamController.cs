using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/ram")]
public class RamController : ControllerBase, IComponentRepository
{
    public readonly IAuthRepository _authRepository;
    public readonly ApplicationDbContext _db;
    public readonly List<ProductCollection> _productCollections;

    public RamController(IAuthRepository authRepository, ApplicationDbContext db, List<ProductCollection> productCollections)
    {
        _authRepository = authRepository;
        _db = db;
        _productCollections = productCollections;
    }

    [HttpGet("getall")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.RAMs.Include(i => i.ramSpecifications).ToJson());
    }

    [HttpGet("getcompatible")]
    public IActionResult GetCompatible(Guid token)
    {
        if (_authRepository.ValidateToken(token))
        {
            var selectedProduct = _productCollections.FirstOrDefault(x => x.token == token);

            if (selectedProduct?.selectedMainboard == null)
            {
                return BadRequest("Kein passender Mainboard für das Token gefunden.");
            }

            var compatibleRAMs = _db.RAMs
                .Include(i => i.ramSpecifications)
                .Where(i => i.ramSpecifications.MemoryType == selectedProduct.selectedMainboard.mainboardSpecifications.memoryType)
                .ToList();

            if (compatibleRAMs == null || !compatibleRAMs.Any())
            {
                return NotFound("Keine passenden RAM gefunden.");
            }

            return Ok(compatibleRAMs.ToJson());
        }

        return Unauthorized();
    }

    [HttpGet("setcomponent")]
    public IActionResult SetComponentAsSelected(Guid token, Guid componentId)
    {
        _productCollections.Where(x => x.token == token).FirstOrDefault().selectedRAM = _db.RAMs.Include(i => i.ramSpecifications).Where(x => x.id == componentId).FirstOrDefault();

        return Ok();
    }


    [HttpGet("getselected")]
    public IActionResult GetSelected(Guid token)
    {
        var t = _productCollections.Where(x => x.token == token).First().selectedRAM;
        return Ok(new Sitebar(t.id, t.name, t.price).ToJson());
    }
}
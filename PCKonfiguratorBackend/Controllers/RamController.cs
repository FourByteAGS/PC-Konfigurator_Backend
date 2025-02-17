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

    public RamController(IAuthRepository authRepository, ApplicationDbContext db,List<ProductCollection> productCollections)
    {
        _authRepository = authRepository;
        _db = db;
      _productCollections = productCollections;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.RAMs.Include(i => i.ramSpecifications).ToJson());
    }

    [HttpGet("GetRAMByType")]    
    public IActionResult GetTowerByTowerType(Guid token)
    {
        if (_authRepository.ValidateToken(token))
        {
            if()
            return Ok(_db.RAMs.Include(i => i.ramSpecifications).Where(i => i.ramSpecifications.MemoryType.Value == MemoryType.DDR5).ToJson());
        }

        return Unauthorized();
    }

    public IActionResult SetComponentAsSelected(Guid token, Guid componentId)
    {
        var t =_productCollections.Select(x => x.token == token).First();
        t.selectedRAM
    }
} 
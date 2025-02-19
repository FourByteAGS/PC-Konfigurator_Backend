using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/storage")]
public class StorageController : ControllerBase, IComponentRepository
{
    public readonly IAuthRepository _authService;
    public readonly ApplicationDbContext _db;
    public readonly List<ProductCollection> _productCollections;

    public StorageController(IAuthRepository authRepository, ApplicationDbContext db)
    {
        _authService = authRepository;
        _db = db;
    }

    [HttpGet("getall")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.Storages.Include(i => i.storageSpecifications).ToJson());
    }

    [HttpGet("setcomponent")]
    public IActionResult SetComponent(Guid token, Guid componentId)
    {
        var productCollection = _productCollections?.FirstOrDefault(x => x.token == token);
    
        if (productCollection == null)
        {
            return NotFound("Product collection not found.");
        }

        var storage = _db.Storages
            .Include(i => i.storageSpecifications)
            .FirstOrDefault(x => x.id == componentId);

        if (storage == null)
        {
            return NotFound("Storage not found.");
        }

        productCollection.selectedStorage = storage;

        return Ok("Komponente erfolgreich gesetzt.");
    }



    [HttpGet("getselected")]
    public IActionResult GetSelected(Guid token)
    {
        var t = _productCollections.Where(x => x.token == token).First().selectedStorage;
        if (t == null)
            return NotFound();
        return Ok(new Sitebar(t.id, t.name, t.price).ToJson());
    }
} 
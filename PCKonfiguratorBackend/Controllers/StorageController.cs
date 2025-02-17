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
    public IActionResult setcomponent(Guid token, Guid componentId)
    {
        _productCollections.Where(x => x.token == token).FirstOrDefault().selectedStorage = _db.Storages.Include(i => i.storageSpecifications).Where(x => x.id == componentId).FirstOrDefault();

        return Ok();
    }


    [HttpGet("getselected")]
    public IActionResult GetSelected(Guid token)
    {
        var t = _productCollections.Where(x => x.token == token).First().selectedStorage;
        return Ok(new Sitebar(t.id, t.name, t.price).ToJson());
    }
} 
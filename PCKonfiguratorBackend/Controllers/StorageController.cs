using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/storage")]
public class StorageController : ControllerBase, IComponentRepository
{
    public readonly IAuthRepository AuthRepository;
    public readonly ApplicationDbContext _db;

    public StorageController(IAuthRepository authRepository, ApplicationDbContext db)
    {
        AuthRepository = authRepository;
        _db = db;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.Storages.Include(i => i.storageSpecifications).ToJson());
    }

    public IActionResult SetComponentAsSelected(Guid token, Guid componentId)
    {
        throw new NotImplementedException();
    }
} 
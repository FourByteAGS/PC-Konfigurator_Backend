using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/storage")]
public class StorageController : ControllerBase, IComponentController
{
    public readonly IAuthService _authService;
    public readonly ApplicationDbContext _db;

    public StorageController(IAuthService authService, ApplicationDbContext db)
    {
        _authService = authService;
        _db = db;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.Storages.Include(i => i.storageSpecifications).ToJson());
    }
} 
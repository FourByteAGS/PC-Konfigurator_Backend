using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/gpu")]
public class GpuController : ControllerBase, IComponentRepository
{
    public readonly IAuthRepository AuthRepository;
    public readonly ApplicationDbContext _db;

    public GpuController(IAuthRepository authRepository, ApplicationDbContext db)
    {
        AuthRepository = authRepository;
        _db = db;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.GPUs.Include(i => i.gpuSpecifications).Include(i => i.dimensions).ToJson());
    }
} 
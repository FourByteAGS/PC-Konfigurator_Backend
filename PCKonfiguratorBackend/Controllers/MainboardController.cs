using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/mainboard")]
public class MainboardController : ControllerBase, IComponentRepository
{
    public readonly IAuthRepository AuthRepository;
    public readonly ApplicationDbContext _db;

    public MainboardController(IAuthRepository authRepository, ApplicationDbContext db)
    {
        AuthRepository = authRepository;
        _db = db;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.Mainboards.Include(i => i.mainboardSpecifications).Include(i => i.dimensions).ToJson());
    }
} 
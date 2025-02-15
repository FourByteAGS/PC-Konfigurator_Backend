using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/mainboard")]
public class MainboardController : ControllerBase, IComponentController
{
    public readonly IAuthService _authService;
    public readonly ApplicationDbContext _db;

    public MainboardController(IAuthService authService, ApplicationDbContext db)
    {
        _authService = authService;
        _db = db;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.Mainboards.Include(i => i.mainboardSpecifications).Include(i => i.dimensions).ToJson());
    }
} 
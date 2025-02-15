using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/psu")]
public class PSUController : ControllerBase, IComponentController
{
    public readonly IAuthService _authService;
    public readonly ApplicationDbContext _db;

    public PSUController(IAuthService authService, ApplicationDbContext db)
    {
        _authService = authService;
        _db = db;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.PSUs.Include(i => i.psuSpecification).Include(i => i.dimensions).ToJson());
    }
} 
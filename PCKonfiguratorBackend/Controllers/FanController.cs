using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/fan")]
public class FanController : ControllerBase, IComponentController
{
    public readonly IAuthService _authService;
    public readonly ApplicationDbContext _db;

    public FanController(IAuthService authService, ApplicationDbContext db)
    {
        _authService = authService;
        _db = db;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.Fans.Include(i => i.fanSpecifications).Include(i => i.dimensions).ToJson());
    }
} 
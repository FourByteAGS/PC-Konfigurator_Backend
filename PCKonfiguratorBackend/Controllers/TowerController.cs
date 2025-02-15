using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers
{

    [ApiController]
    [Route("api/tower")]
    public class TowerController:ControllerBase,IComponentController
    {
        public readonly IAuthService _authService;
        public readonly ApplicationDbContext _db;

        public TowerController(IAuthService authService, ApplicationDbContext db)
        {
            _authService = authService;
            _db = db;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(Guid token)
        {           
            return Ok(_db.Towers.Include(i => i.towerCompatibility).Include(i => i.dimensions).ToJson());
        }
    }
}

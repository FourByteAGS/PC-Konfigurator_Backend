using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers;

    [ApiController]
    [Route("api/cpuFan")]
    public class CPUFanController : ControllerBase, IComponentController
    {
        public readonly IAuthService _authService;
        public readonly ApplicationDbContext _db;

        public CPUFanController(IAuthService authService, ApplicationDbContext db)
        {
            _authService = authService;
            _db = db;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(Guid token)
        {
            return Ok(_db.CPUFans.Include(i => i.cpufanSpecifications).Include(i => i.dimensions).ToJson());
        }
    }   

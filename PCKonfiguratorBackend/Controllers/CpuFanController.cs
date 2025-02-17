using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers;

    [ApiController]
    [Route("api/cpufan")]
    public class CpuFanController : ControllerBase, IComponentRepository
    {
        public readonly IAuthRepository AuthRepository;
        public readonly ApplicationDbContext _db;

        public CpuFanController(IAuthRepository authRepository, ApplicationDbContext db)
        {
            AuthRepository = authRepository;
            _db = db;
        }

    [HttpGet("getall")]
    public IActionResult GetAll(Guid token)
        {
            return Ok(_db.CPUFans.Include(i => i.cpufanSpecifications).Include(i => i.dimensions).ToJson());
        }
    }   

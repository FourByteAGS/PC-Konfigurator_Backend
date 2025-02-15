using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers;

    [ApiController]
    [Route("api/cpuFan")]
    public class CpuFanRepository : ControllerBase, IComponentRepository
    {
        public readonly IAuthRepository AuthRepository;
        public readonly ApplicationDbContext _db;

        public CpuFanRepository(IAuthRepository authRepository, ApplicationDbContext db)
        {
            AuthRepository = authRepository;
            _db = db;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(Guid token)
        {
            return Ok(_db.CPUFans.Include(i => i.cpufanSpecifications).Include(i => i.dimensions).ToJson());
        }
    }   

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers
{
    [ApiController]
    [Route("api/cpu")]
    public class CpuController : ControllerBase, IComponentRepository
    {
        public readonly IAuthRepository AuthRepository;
        public readonly ApplicationDbContext _db;

        public CpuController(IAuthRepository authRepository, ApplicationDbContext db)
        {
            AuthRepository = authRepository;
            _db = db;
        }

        [HttpGet("getall")]
        public IActionResult GetAll(Guid token)
        {
            return Ok(_db.Cpus.Include(i => i.cpuSpecification).ThenInclude(i => i.cpuMemory).ToJson());
        }

        //[HttpGet("SetFormat")]
        //public IActionResult SetFormat(Guid token,int type)
        //{

        //}

        //public 

    }
}

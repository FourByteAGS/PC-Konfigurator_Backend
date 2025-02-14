using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers
{
    [ApiController]
    [Route("api/cpu")]
    public class CPUController : ControllerBase, IComponentController
    {
        public readonly IAuthService _authService;
        public readonly ApplicationDbContext _db;

        public CPUController(IAuthService authService, ApplicationDbContext db)
        {
            _authService = authService;
            _db = db;
        }

        [HttpGet("GetAll")]
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

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Controllers
{
    [ApiController]
    [Route("api/cpu")]
    public class CpuController : ControllerBase, IComponentRepository
    {
        public readonly IAuthRepository _authService;
        public readonly ApplicationDbContext _db;
        public readonly List<ProductCollection> _productCollections;

        public CpuController(IAuthRepository authRepository, ApplicationDbContext db, List<ProductCollection> productCollections)
        {
            _authService = authRepository;
            _db = db;
            _productCollections = productCollections;
        }

        [HttpGet("getall")]
        public IActionResult GetAll(Guid token)
        {
            return Ok(_db.Cpus.Include(i => i.cpuSpecification).ThenInclude(i => i.cpuMemory).ToJson());
        }

        [HttpGet("getbymanifacture")]
        public IActionResult GetByManifacture(Guid token, string manifacture)
        {
            return Ok(_db.Cpus.Include(i => i.cpuSpecification).ThenInclude(i => i.cpuMemory).Where(x=>x.manufacturer.ToLower()==manifacture.ToLower()).ToJson());
        }

        [HttpGet("setcomponent")]
        public IActionResult SetComponent(Guid token, Guid componentId)
        {
            if (!_authService.ValidateToken(token))
            {
                return Unauthorized();
            }

            var cpu = _db.Cpus.Include(i => i.cpuSpecification).ThenInclude(i => i.cpuMemory).FirstOrDefault(i => i.id == componentId);
            _productCollections.Where(x => x.token == token).FirstOrDefault().selectedCPU = cpu;
            return Ok();
        }

        [HttpGet("getselected")]
        public IActionResult GetSelected(Guid token)
        {
            var t = _productCollections.Where(x => x.token == token).First().selectedCPU;
            if (t == null)
                return NotFound();
            return Ok(new Sitebar(t.id, t.name, t.price).ToJson());
        }
    }
}

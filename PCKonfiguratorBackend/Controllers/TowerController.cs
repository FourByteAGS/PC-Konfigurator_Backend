using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Controllers
{

    [ApiController]
    [Route("api/tower")]
    public class TowerController : ControllerBase, IComponentRepository
    {
        private readonly IAuthRepository _authService;
        private readonly ApplicationDbContext _db;
        private List<ProductCollection> _productCollections;

        public TowerController(IAuthRepository authRepository, ApplicationDbContext db, List<ProductCollection> productCollections)
        {
            _authService = authRepository;
            _db = db;
            _productCollections = productCollections;

        }

        [HttpGet("getall")]
        public IActionResult GetAll(Guid token)
        {
            return Ok(_db.Towers.Include(i => i.towerCompatibility).Include(i => i.dimensions).ToJson());
        }

        [HttpGet("setcomponent")]
        public IActionResult SetComponent(Guid token, Guid componentId)
        {
            if (!_authService.ValidateToken(token))
            {
                return Unauthorized();
            }

            var tower = _db.Towers.Include(i=>i.towerCompatibility).Include(i=>i.dimensions).FirstOrDefault(i => i.id == componentId);
            
            if(!_productCollections.Any()|| _productCollections.Where(x => x.token == token).Any())
            _productCollections.Add(new ProductCollection(token));
            _productCollections.Where(x => x.token == token).FirstOrDefault().selectedTower = tower;
            return Ok();
        }

        [HttpGet("gettowerbyformfactor")]
        public IActionResult GetTowerByformfactor(Guid token, [FromQuery] FormFactor formFactor)
        {
            if (_authService.ValidateToken(token))
            {
                return Ok(_db.Towers.Include(i => i.towerCompatibility).Include(i => i.dimensions).Where(i => i.formFactor.Value == formFactor).ToJson());
            }

            return Unauthorized();
        }

        [HttpGet("getselected")]
        public IActionResult GetSelected(Guid token)
        {
            var t = _productCollections.Where(x => x.token == token).First().selectedTower;
            if (t == null)
                return NotFound();
            return Ok(new Sitebar(t.id, t.name, t.price).ToJson());
        }
    }
}

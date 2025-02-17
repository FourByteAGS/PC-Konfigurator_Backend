using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Controllers
{

    [ApiController]
    [Route("api/tower")]
    public class TowerController:ControllerBase,IComponentRepository
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

        [HttpGet("GetAll")]
        public IActionResult GetAll(Guid token)
        {           
            return Ok(_db.Towers.Include(i => i.towerCompatibility).Include(i => i.dimensions).ToJson());
        }
        
        [HttpGet("SetComponentAsSelected")]
        public IActionResult SetComponentAsSelected(Guid token, Guid componentId)
        {
            if (!_authService.ValidateToken(token))
            {
                return Unauthorized();
            }
            
            var tower = _db.Towers.FirstOrDefault(i => i.id == componentId);
        }

        [HttpGet("GetTowerByFormFactor")]
        public IActionResult GetTowerByTowerType(Guid token, [FromQuery] FormFactor formFactor)
        {
            if (_authService.ValidateToken(token))
            {
                return Ok(_db.Towers.Include(i => i.towerCompatibility).Include(i => i.dimensions).Where(i => i.formFactor.Value == formFactor).ToJson());
            }

            return Unauthorized();
        }
    }
}

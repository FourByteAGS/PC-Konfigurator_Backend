using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend.Controllers
{

    [ApiController]
    [Route("api/tower")]
    public class TowerRepository:ControllerBase,IComponentRepository
    {
        public readonly IAuthRepository AuthRepository;
        public readonly ApplicationDbContext _db;

        public TowerRepository(IAuthRepository authRepository, ApplicationDbContext db)
        {
            AuthRepository = authRepository;
            _db = db;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(Guid token)
        {           
            return Ok(_db.Towers.Include(i => i.towerCompatibility).Include(i => i.dimensions).ToJson());
        }

        [HttpGet("GetTowerByTowerType")]
        public IActionResult GetTowerByTowerType(Guid token, [FromQuery] TowerType towerType)
        {
            return Ok(_db.Towers.Include(i => i.towerCompatibility).Include(i => i.dimensions).Where(i => i.towerType.Value == towerType).ToJson());
        }
        
        public IActionResult SetTowerAsSelected(Guid token, Guid towerId)
        {
            // if (!_authService.ValidateToken(token))
            // {
            //     return Unauthorized();
            // }

            var tower = _db.Towers.FirstOrDefault(i => i.id == towerId);
            //save tower in SelectedProducts but we need a singelton for that ????
            
            return Ok();
        }
    }
}

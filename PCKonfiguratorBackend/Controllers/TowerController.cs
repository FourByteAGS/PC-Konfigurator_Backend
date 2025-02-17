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
        public readonly IAuthRepository authRepository;
        public readonly ApplicationDbContext _db;
        public readonly List<ProductCollection> productCollections;

        public TowerController(IAuthRepository authRepository, ApplicationDbContext db, List<ProductCollection> productCollections)
        {
            this.authRepository = authRepository;
            _db = db;
            this.productCollections = productCollections;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(Guid token)
        {           
            return Ok(_db.Towers.Include(i => i.towerCompatibility).Include(i => i.dimensions).ToJson());
        }

        [HttpGet("GetTowerByFormFactor")]
        public IActionResult GetTowerByTowerType(Guid token, [FromQuery] FormFactor formFactor)
        {
            if (authRepository.ValidateToken(token))
            {
                return Ok(_db.Towers.Include(i => i.towerCompatibility).Include(i => i.dimensions).Where(i => i.formFactor.Value == formFactor).ToJson());
            }

            return Unauthorized();
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

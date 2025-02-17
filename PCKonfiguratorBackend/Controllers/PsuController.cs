using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;
using PCKonfiguratorBackend.Service;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/psu")]
public class PsuController : ControllerBase, IComponentRepository
{
    public readonly IAuthRepository _authService;
    public readonly ApplicationDbContext _db;
    public readonly List<ProductCollection> _productCollections;

    public PsuController(IAuthRepository authRepository, ApplicationDbContext db, List<ProductCollection> productCollections)
    {
        _authService = authRepository;
        _db = db;
        _productCollections = productCollections;
    }

    [HttpGet("getall")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.PSUs.Include(i => i.psuSpecification).Include(i => i.dimensions).ToJson());
    }

    [HttpGet("setcomponent")]
    public IActionResult SetComponent(Guid token, Guid componentId)
    {
        if (!_authService.ValidateToken(token))
        {
            return Unauthorized();
        }

        var psu = _db.PSUs.Include(i => i.psuSpecification).Include(i => i.dimensions).FirstOrDefault(i => i.id == componentId);
        _productCollections.Where(x => x.token == token).FirstOrDefault().selectedPSU = psu;
        return Ok();
    }
}
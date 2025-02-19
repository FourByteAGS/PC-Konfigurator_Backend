using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;
using PCKonfiguratorBackend.Service;
using System.Linq;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/cpufan")]
public class CpuFanController : ControllerBase, IComponentRepository
{
    public readonly IAuthRepository _authService;
    public readonly ApplicationDbContext _db;
    public readonly List<ProductCollection> _productCollections;

    public CpuFanController(IAuthRepository authRepository, ApplicationDbContext db, List<ProductCollection> productCollections)
    {
        _authService = authRepository;
        _db = db;
        _productCollections = productCollections;
    }

    [HttpGet("getall")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.CPUFans.Include(i => i.cpufanSpecifications).Include(i => i.dimensions).ToJson());
    }

    [HttpGet("getbyheatpipes")]
    public IActionResult GetByHeatpipes(Guid token, bool isLiquid)
    {
        return Ok(_db.CPUFans.Include(i => i.cpufanSpecifications).Include(i => i.dimensions).Where(x=>(x.cpufanSpecifications.heatpipes.Contains("Liquid")&&isLiquid)||(!x.cpufanSpecifications.heatpipes.Contains("Liquid") && !isLiquid)).ToJson());
    }

    [HttpGet("setcomponent")]
    public IActionResult SetComponent(Guid token, Guid componentId)
    {
        if (!_authService.ValidateToken(token))
        {
            return Unauthorized();
        }

        var cpuFan = _db.CPUFans.Include(i => i.cpufanSpecifications).Include(i => i.dimensions).FirstOrDefault(i => i.id == componentId);
        _productCollections.Where(x => x.token == token).FirstOrDefault().selectedCPUFan = cpuFan;
        return Ok();
    }


    [HttpGet("getselected")]
    public IActionResult GetSelected(Guid token)
    {
        var t = _productCollections.Where(x => x.token == token).First().selectedCPUFan;
        if (t == null)
            return NotFound();
        return Ok(new Sitebar(t.id, t.name, t.price).ToJson());
    }
}

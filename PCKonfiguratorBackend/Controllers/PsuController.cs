using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;
using PCKonfiguratorBackend.Models;

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


    [HttpGet("getselected")]
    public IActionResult GetSelected(Guid token)
    {
        var t = _productCollections.Where(x => x.token == token).First().selectedPSU;
        if (t == null)
            return NotFound();
        return Ok(new Sitebar(t.id, t.name, t.price).ToJson());
    }

    [HttpGet("getcompatible")]
    public IActionResult GetCompatible(Guid token)
    {
        if (_authService.ValidateToken(token))
        {
            var selectedProduct = _productCollections.FirstOrDefault(x => x.token == token);

            int MaxTotalPower = 0;
            MaxTotalPower += (int)selectedProduct.selectedCPU.cpuSpecification.power;
            MaxTotalPower += (int)selectedProduct.selectedMainboard.mainboardSpecifications.power;
            MaxTotalPower += (int)selectedProduct.selectedRAM.ramSpecifications.power;
            MaxTotalPower += (int)selectedProduct.selectedGPU.gpuSpecifications.power;
            MaxTotalPower += (int)selectedProduct.selectedStorage.storageSpecifications.power;
            MaxTotalPower += (int)selectedProduct.selectedFan.fanSpecifications.power;
            MaxTotalPower += 100;

            var psu = _db.PSUs
                .Include(i => i.psuSpecification)
                .Include(i => i.dimensions)
                .Where(i => (int)i.psuSpecification.power >= MaxTotalPower)
                .ToList();

            if (psu == null || !psu.Any())
            {
                return NotFound("Keine passenden PSU gefunden.");
            }

            return Ok(psu.ToJson());
        }

        return Unauthorized();
    }
}
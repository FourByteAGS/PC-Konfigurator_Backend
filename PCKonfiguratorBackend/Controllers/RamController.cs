﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/ram")]
public class RamController : ControllerBase, IComponentRepository
{
    public readonly IAuthRepository AuthRepository;
    public readonly ApplicationDbContext _db;

    public RamController(IAuthRepository authRepository, ApplicationDbContext db)
    {
        AuthRepository = authRepository;
        _db = db;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.RAMs.Include(i => i.ramSpecifications).ToJson());
    }
} 
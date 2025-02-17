﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Interface;

namespace PCKonfiguratorBackend.Controllers;

[ApiController]
[Route("api/fan")]
public class FanController : ControllerBase, IComponentRepository
{
    public readonly IAuthRepository AuthRepository;
    public readonly ApplicationDbContext _db;

    public FanController(IAuthRepository authRepository, ApplicationDbContext db)
    {
        AuthRepository = authRepository;
        _db = db;
    }

    [HttpGet("getall")]
    public IActionResult GetAll(Guid token)
    {
        return Ok(_db.Fans.Include(i => i.fanSpecifications).Include(i => i.dimensions).ToJson());
    }
} 
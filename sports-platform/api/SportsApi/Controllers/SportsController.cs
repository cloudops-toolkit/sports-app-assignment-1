using Microsoft.AspNetCore.Mvc;
using SportsApi.Services;
using SportsApi.Models;

namespace SportsApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SportsController : ControllerBase
{
    private readonly ISportService _sportService;

    public SportsController(ISportService sportService)
    {
        _sportService = sportService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var sports = await _sportService.GetAllSports();
        return Ok(sports);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var sport = await _sportService.GetSportById(id);
        if (sport == null) return NotFound();
        return Ok(sport);
    }

    [HttpGet("health")]
    public IActionResult Health() => Ok(new { status = "healthy", timestamp = DateTime.UtcNow });
}
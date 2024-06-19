using StationApiExercise.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StationApiExercise.Database;

namespace StationApiExercise.Controllers;

[ApiController]
[Route("[controller]")]
public class StationController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<StationDto>>> GetStations()
    {
        return Ok(await new StationDbContext().Stations.ToListAsync());
        // Just to make the compiler happy for now.
        return await Task.Run(() => Ok(new List<StationDto> { new(1, 123) }));
    }
}
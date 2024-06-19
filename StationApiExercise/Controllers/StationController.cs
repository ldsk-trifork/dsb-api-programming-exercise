using StationApiExercise.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace StationApiExercise.Controllers;

[ApiController]
[Route("[controller]")]
public class StationController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<StationDto>>> GetStations()
    {
        // Just to make the compiler happy for now.
        return await Task.Run(() => Ok(new List<StationDto> { new(1, 123) }));
    }
}
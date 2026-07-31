using Microsoft.AspNetCore.Mvc;

namespace NeuroLean.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
            return Ok(new
        {
            status = "NeuroLearn API is running",
            version = "0.1"
        });
    }
}
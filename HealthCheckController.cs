using Microsoft.AspNetCore.Mvc;

namespace PersonalAIHub.Test;

[ApiController]
[Route("api/test")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    public IActionResult Check()
    {
        return Ok(new {
            success = true,
            data = "Hệ thống Personal AI Hub hoạt động ổn định.",
            error = (object)null,
            meta = new {
                request_id = Guid.NewGuid().ToString(),
                timestamp = DateTime.UtcNow
            }
        });
    }
}

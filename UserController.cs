using Microsoft.AspNetCore.Mvc;

namespace PersonalAIHub.Test;

/// <summary>
/// Controller quản lý người dùng - Tuân thủ ISC v1.0
/// </summary>
[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers()
    {
        // Biến local dùng camelCase theo chuẩn
        var userList = new List<object> 
        { 
            new { id = 1, username = "huynt92" },
            new { id = 2, username = "gemini.agent" }
        };

        return Ok(new {
            success = true,
            data = userList,
            error = (object)null,
            meta = new {
                request_id = Guid.NewGuid().ToString(),
                trace_id = HttpContext?.TraceIdentifier ?? "N/A",
                timestamp = DateTime.UtcNow
            }
        });
    }
}

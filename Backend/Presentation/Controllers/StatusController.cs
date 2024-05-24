using Domain.Interfaces.Services.Status;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/status")]
public class StatusController(IStatusService statusService) : ControllerBase
{
    private readonly IStatusService _statusService = statusService;
    
    //[Authorize]
    [HttpGet]
    public async Task<IActionResult> GetStatuses()
    {
        var result = await _statusService.GetStatusList();
        
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest("Error ved henting av statuslisten");
    }
}
using Application.Services.Business;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/business")]
public class BusinessController(IBusinessService businessService) : ControllerBase
{
    private readonly IBusinessService _businessService = businessService;

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetBusinessList()
    {
        var result = await _businessService.GetBusinessList();

        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest("Error ved henting av bedriftslisten");
    }
}
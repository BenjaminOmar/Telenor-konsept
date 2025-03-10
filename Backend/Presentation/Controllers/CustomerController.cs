using Domain.DTOs.Customer;
using Domain.Interfaces.Services.Customer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/customer")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;
    private readonly IBrregService _brregService;

    public CustomerController(ICustomerService customerService, IBrregService brregService)
    {
        _customerService = customerService;
        _brregService = brregService;
    }
    
    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetCustomer()
    {
        var result = await _customerService.GetCustomerList();
        
        if (result.IsSuccess)
        {
            return Ok(result);
        }

        return BadRequest("Error ved henting av kundeliste");
    }
    
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerRequestDto customerRequestDto)
    {
        var result = await _customerService.CreateCustomer(customerRequestDto);

        if (!result.IsSuccess)
        {
            return result.ErrorCode switch
            {
                404 => NotFound(result),
                409 => Conflict(result),
                400 => BadRequest(result),
                401 => Unauthorized(result),
                _ => StatusCode(500, result)
            };
        }

        return Ok(result.Value.Name + " " + "er oprettet");
    }

    [Authorize]
    [HttpGet("options")]
    public async Task<IActionResult> GetCreateCustomerOptions()
    {
        var result = await _customerService.GetCustomerOptions();

        if (result.Value.Status is null)
        {
            return Empty;
        }
        
        return Ok(result);
    }
    
    [Authorize]
    [HttpGet("brreg")]
    public async Task<IActionResult> GetBrreg([FromQuery] string? name, [FromQuery] string? organizationNumber)
    {
        var result = await _brregService.GetBrregInfo(name, organizationNumber);
        
        if (!result.IsSuccess)
        {
            return result.ErrorCode switch
            {
                404 => NotFound(result),
                409 => Conflict(result),
                400 => BadRequest(result),
                401 => Unauthorized(result),
                _ => StatusCode(500, result)
            };
        }
        
        return Ok(result);
    }
    
}
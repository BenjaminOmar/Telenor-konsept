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

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }
    
    //[Authorize]
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
    
    //[Authorize]
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
                _ => StatusCode(500, result)
            };
        }
        
        return Created();
    }
}
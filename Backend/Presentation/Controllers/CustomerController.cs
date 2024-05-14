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
}
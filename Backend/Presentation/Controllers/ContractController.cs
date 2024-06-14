using Domain.Interfaces.Services.Contact;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/contact")]
public class ContractController(IContactService contactService) : ControllerBase
{
    private readonly IContactService _contactService = contactService;

    //[Authorize]
    [HttpGet]
    [Route("{customerId}")]
    public async Task<IActionResult> GetContacts(Guid customerId)
    {
        var result = await _contactService.GetContactList(customerId);
        
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
using Microsoft.AspNetCore.Mvc;
using WebDinparbudpora.Application.Common.Interfaces;

namespace WebDinparbudpora.API.Controllers;

[Route("api/users")]
public class UserController : ControllerBase
{
    [HttpGet("id")]
    public async Task<IActionResult> Id([FromServices] IUserRepository repo)
    {
        var user = await repo.GetByUsernameAsync("testusername");

        if(user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }
}
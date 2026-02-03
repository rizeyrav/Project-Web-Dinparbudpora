using Microsoft.AspNetCore.Mvc;

using WebDinparbudpora.Application.UseCases.Auth.Login;

namespace WebDinparbudpora.API.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        Console.WriteLine("Sedang Menjalankan Usecase Login");
        var UseCase = new LoginUseCase();
        var result = UseCase.Execute(request);

        if (!result.IsSuccess)
        {
            return Unauthorized(result);   
        }return Ok(result);
    }
}
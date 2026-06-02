using Banking.Api.Models;
using Banking.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Banking.Api.Controllers;

[ApiController]
[Route("api/v1/auth")]
public class AuthController : ControllerBase
{
    private readonly JwtService _jwtService;

    public AuthController(JwtService jwtService)
    {
        _jwtService = jwtService;
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        if (request.Username != "admin"
            || request.Password != "Password123!")
        {
            return Unauthorized();
        }

        var token =
            _jwtService.GenerateToken(
                new User
                {
                    Username = request.Username
                });

        return Ok(new { token });
    }
}
using Microsoft.AspNetCore.Mvc;
using MyAspNetApp.Services;
using MyAspNetApp.Models.DTOs;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("signup")]
    public async Task<IActionResult> SignUp(SignUpDto signUpDto)
    {
        try
        {
            var user = await _authService.SignUpAsync(signUpDto);
            return Ok(new { Message = "User created successfully", UserId = user.Id });
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
    }

    [HttpPost("signin")]
    public async Task<IActionResult> SignIn(SignInDto signInDto)
    {
        try
        {
            var user = await _authService.SignInAsync(signInDto);
            return Ok(new { Message = "Sign in successful", UserId = user.Id });
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
    }
} 
using Microsoft.AspNetCore.Mvc;
using JobBoard.API.Services;
using JobBoard.API.DTOs.Auth;

namespace JobBoard.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        public AuthController(AuthService authService)
        {
            _authService = authService;
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            var authResponse = await _authService.Login(dto);
            return authResponse != null ? Ok(authResponse) : Unauthorized();
        }

    }
}

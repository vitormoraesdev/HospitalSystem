using Application.ApplicationService;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly AuthenticationService _authenticationService;
        private readonly JwtService _jwtService;
        public AuthenticationController(AuthenticationService authenticationService, JwtService jwtService)
        {
            _authenticationService = authenticationService;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestModel loginModel)
        {
            var token = await _authenticationService.AuthenticationAsync(loginModel.Email, loginModel.Cpf, loginModel.Password);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(new { Token = token });
        }
    }
}

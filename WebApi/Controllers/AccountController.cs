using Application.ApplicationService;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserRegistrationService _userRegistrationService;
        public AccountController(UserRegistrationService userRegistrationService)
        {
            _userRegistrationService = userRegistrationService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequestModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _userRegistrationService.RegisterAsync(registerModel.Name, registerModel.Cpf, registerModel.Email, registerModel.Password, registerModel.UserType);

            if (result.Succeeded)
            {
                return Ok(new { Message = "User registered successfully" });
            }
            else
            {
                return BadRequest(new { Message = "Failed to register user", Errors = result.Errors });
            }
        }
    }
}

using Application.ApplicationService;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("WebApi/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly AuthenticationService _authenticationService;
        public AuthenticationController(AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        //[HttpPost("login")]
        //public Task<IActionResult> Login(LoginRequestModel loginModel)
        //{
        //    var token = _authenticationService.AuthenticationAsync(loginModel.Email, loginModel.Cpf, loginModel.Password);

        //    if( token == null )
        //    {
        //        return Unauthorized();
        //    }
        //    return Ok();
        //}
    }
}

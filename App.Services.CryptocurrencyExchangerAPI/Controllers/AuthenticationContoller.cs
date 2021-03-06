using App.Components.Utilities.JWT_Auth;
using Microsoft.AspNetCore.Mvc;


namespace App.CryptocurrencyExchanger.Controllers
{   
    [ApiController]   
    public class AuthenticationContoller : ControllerBase
    {       
        [HttpPost("api/authentication/token")]
        public IActionResult Token([FromServices]IUserService userService,AuthenticateRequest model)
        {
            var response = userService.Authenticate(model);

            if (response == null)
                return Unauthorized(new { message = "Username or password is incorrect" });

            return Ok(response);
        }
       
    }
}

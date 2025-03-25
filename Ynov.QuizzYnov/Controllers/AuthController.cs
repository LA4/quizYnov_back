using AspNet.Security.OAuth.GitHub;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ynov.QuizzYnov.Business;
using Ynov.QuizzYnov.Business.Models;
using Ynov.QuizzYnov.Business.Services;

namespace Ynov.QuizzYnov.Controllers;

[ApiController]
[Route("auth")]
public class AuthController(IUserService _service) : ControllerBase
{
    [HttpGet("signin")]
    [ProducesResponseType(302)]
 
    public IActionResult SignIn()
    {
        var properties = new AuthenticationProperties
        {
            RedirectUri = "/auth/callback",
        };
        return Challenge(properties, GitHubAuthenticationDefaults.AuthenticationScheme);
    }

    [Authorize]
    [HttpGet("callback")]
    [ProducesResponseType(302)]

    public async Task<IActionResult> HandleCallback()
    {
        await _service.HandleSuccessfulSignin(User.Claims);
        return RedirectToAction(nameof(UserInfo));
    }

    [Authorize]
    [HttpGet("userinfo")]
    [ProducesResponseType<User>(200)]
    public async Task<IActionResult> UserInfo()
    {
        var user = await _service.getCurrent(User.Claims);
        return Ok(user);
    }
}
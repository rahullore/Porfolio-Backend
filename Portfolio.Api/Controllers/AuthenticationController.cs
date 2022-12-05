using Microsoft.AspNetCore.Mvc;
using Portfolio.Contracts.Authentication;
using Portfolio.Application.Services.Authentication;

namespace Portfolio.Api.Controllers;

[ApiController]

[Route("auth")]
public class AuthenticationController:ControllerBase
{
    private IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService=authenticationService;        
    }


    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authenticationService.Login(request.Email,request.Password);
        var response = new AuthenticationResponse(authResult.Id,authResult.FirstName,authResult.LastName,authResult.Email,authResult.Token);
        return Ok(response);
    }     
}
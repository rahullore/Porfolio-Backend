namespace Portfolio.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResponse Login(string email,string password);
    
}
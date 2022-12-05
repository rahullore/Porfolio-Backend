namespace Portfolio.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResponse Login(string email, string password)
    {
        return new AuthenticationResponse(
            Guid.NewGuid(),"Rahul","Lore",email,"token"
        );
    }
}
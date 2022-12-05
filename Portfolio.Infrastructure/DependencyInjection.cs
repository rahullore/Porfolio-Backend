using Microsoft.Extensions.DependencyInjection;
using Portfolio.Application.Services.Authentication;

namespace Portfolio.Infrastructure;

public static class DependencyInjection{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //services.AddScoped<IAuthenticationService,IAuthenticationService>();
        return services;
    }
}
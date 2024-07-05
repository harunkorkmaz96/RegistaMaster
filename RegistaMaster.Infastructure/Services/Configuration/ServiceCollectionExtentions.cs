using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using RegistaMaster.Application.Repositories;
using RegistaMaster.Application.Services.SecurityService;
using RegistaMaster.Infastructure.Repositories;
using RegistaMaster.Infastructure.Services.SecurityServices;

namespace RegistaMaster.Infastructure.Services.Configuration;

public static class ServiceCollectionExtentions
{
  public static void MyRepository(this IServiceCollection services)
  {
    services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
    services.AddTransient<IUnitOfWork, UnitOfWork>();
    services.AddTransient<ISessionService,SessionService>();
  }
}

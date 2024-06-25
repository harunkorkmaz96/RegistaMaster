using RegistaMaster.Domain.DTOModels.SecurityModels;
using RegistaMaster.Domain.Entities;

namespace RegistaMaster.Application.Services.SecurityService;

public interface ISessionService
{
  void SetSession<T>(string key, T model);
  T GetSession<T>(string key);
  SessionDTO GetUser();
  void SetUser(User user);
  SessionDTO GetInjection();
  void CleanSession();
  ProjectSessionDTO GetProject();
}

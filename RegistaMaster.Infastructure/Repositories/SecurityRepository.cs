using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaMaster.Application.Repositories;
using RegistaMaster.Application.Services.SecurityService;
using RegistaMaster.Domain.DTOModels.LoginModels;
using RegistaMaster.Domain.DTOModels.SecurityModels;
using RegistaMaster.Domain.Entities;
using RegistaMaster.Domain.Enums;
using RegistaMaster.Infastructure.Services.SecurityServices;
using RegistaMaster.Persistance.RegistaMasterContextes;

namespace RegistaMaster.Infastructure.Repositories;

public class SecurityRepository(IUnitOfWork unitOfWork, ISessionService session) :ISecurityRepository
{
  private readonly IUnitOfWork _unitOfWork = unitOfWork;
  private readonly ISessionService _session = session;

  public async Task<string> Login(string userName, string password, string url)
  {
    try
    {
      var user = await _unitOfWork.BaseRepository.Find<User>(t => (t.UserName == userName || t.Email == userName) &&
   t.Password == password && t.ObjectStatus == ObjectStatus.NonDeleted && t.Status == Status.Active);
      if (user != null)
      {
        _session.SetUser(user);
        return url != null && url != "/" ? url : "/Home/Index";
      }
      else
      {
        return "Kullanıcı Adı veya Şifre Hatalı";
      }
    }
    catch (Exception e)
    {
      throw;
    }
  }


  public LoginDTO Login(PathString url)
  {
    try
    {
      var model = new LoginDTO
      {
        Url = url,
      };
      var user = _session.GetUser();
      return model;
    }
    catch (Exception e)
    {

      throw e;
    }

  }

  public void Logout()
  {
    _session.CleanSession();
  }
}



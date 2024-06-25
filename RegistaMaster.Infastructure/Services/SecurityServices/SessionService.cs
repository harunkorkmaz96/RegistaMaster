using Microsoft.AspNetCore.Http;
using RegistaMaster.Application.Services.SecurityService;
using RegistaMaster.Domain.DTOModels.SecurityModels;
using RegistaMaster.Domain.Entities;
using RegistaMaster.Domain.Enums;
using RegistaMaster.Domain.Exceptions;
using RegistaMaster.Persistance.RegistaMasterContextes;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace RegistaMaster.Infastructure.Services.SecurityServices;

public class SessionService(IHttpContextAccessor contextAccessor, RegistaMasterContext context) : ISessionService
{
  private readonly IHttpContextAccessor _contextAccessor = contextAccessor;
  private readonly RegistaMasterContext _context = context;

  public void CleanSession()
  {
    _contextAccessor.HttpContext.Session.Clear();
  }

  public SessionDTO GetInjection()
  {
    var user = new SessionDTO();
    user.Id = -1;
    if (_contextAccessor.HttpContext == null)
    {
      user.Id = -1;
      return user;
    }
    var val = _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
    if (val != null)
    {
      var val2 = _contextAccessor.HttpContext.User.FindFirst("CustomerId");
      if (val2 != null)
        user.CustomerId = Convert.ToInt32(val2.Value);
      if (val != null)
        user.CustomerId = Convert.ToInt32(val.Value);
    }
    else
    {
      var usr = GetUser();
      if (usr != null)
        user = usr;
    }
    return user;
  }

  public ProjectSessionDTO GetProject()
  {
    try
    {
      var key = _contextAccessor.HttpContext.Request.Headers["Authorization"].ToString();

      return _context.Projects.Where(t => t.ProjectGuid.ToString() == key && t.ObjectStatus == ObjectStatus.NonDeleted && t.Status == Status.Active).Select(s => new ProjectSessionDTO()
      {
        Id = s.Id,
        Name = s.ProjectName
      }).FirstOrDefault();
    }
    catch (Exception)
    {

      throw new UnAuth("Giriş Yapılamadı");
    }
  }

  public T GetSession<T>(string key)
  {
    try
    {
      var session = _contextAccessor.HttpContext.Session;
      byte[] ss;
      var ctry = session.TryGetValue(key, out ss);
      if (!ctry)
        return default(T);
      if (ss == null)
        return default(T);

      return FromByteArray<T>(ss);
    }
    catch (Exception e)
    {
      throw e;
    }
  }

  public SessionDTO GetUser()
  {
    return GetSession<SessionDTO>("login");
  }

  public void SetSession<T>(string key, T model)
  {
    try
    {
      var ss = ToByteArray<T>(model);
      _contextAccessor.HttpContext.Session.Set(key, ss);
    }
    catch (Exception e)
    {

      throw e;
    }
  }

  public void SetUser(User user)
  {
    try
    {
      var session = new SessionDTO()
      {
        CustomerId = user.CustomerId,
        Id = user.Id,
        Name = user.Name,
        SurName = user.SurName,
        AuthorizationStatus = user.AuthorizationStatus,
      };
      SetSession("login", session);
    }
    catch (Exception e)
    {

      throw e;
    }
  }

  public T FromByteArray<T>(byte[] data)
  {
    if (data == null)
      return default(T);
    var stringObj = Encoding.ASCII.GetString(data);
    return JsonSerializer.Deserialize<T>(stringObj);
  }
  public byte[] ToByteArray<T>(T obj)
  {
    var objToString = JsonSerializer.Serialize(obj);
    return Encoding.ASCII.GetBytes(objToString);
  }
}

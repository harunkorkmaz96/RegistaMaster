﻿using RegistaMaster.Application.Repositories;
using RegistaMaster.Application.Services.SecurityService;
using RegistaMaster.Domain.DTOModels.SecurityModels;
using RegistaMaster.Persistance.RegistaMasterContextes;

namespace RegistaMaster.Infastructure.Repositories;

public class UnitOfWork(RegistaMasterContext context, ISessionService sessionService) : IUnitOfWork
{
  private readonly SessionDTO _session = sessionService.GetInjection();
  private readonly RegistaMasterContext _context = context;
  private readonly ISessionService _sessionService = sessionService;

  private IBaseRepository _baseRepository;
  private ISecurityRepository _securityRepository;
  private IHomeRepository _homeRepository;

  public IBaseRepository BaseRepository => _baseRepository ??= _baseRepository = new BaseRepository(_session, _context);
  public ISecurityRepository SecurityRepository => _securityRepository ??= _securityRepository = new SecurityRepository(this, _sessionService);
  public IHomeRepository HomeRepository => _homeRepository ??= _homeRepository = new HomeRepository(this,_session,context);

  public SessionDTO GetSession()
  {
    try
    {
      return _session;
    }
    catch (Exception ex)
    {

      throw ex;
    }
  }
}

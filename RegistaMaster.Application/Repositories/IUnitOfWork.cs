using RegistaMaster.Domain.DTOModels.SecurityModels;

namespace RegistaMaster.Application.Repositories;

public interface IUnitOfWork
{
  IBaseRepository BaseRepository { get; }
  ISecurityRepository SecurityRepository { get; }
  IHomeRepository HomeRepository { get; }
  SessionDTO GetSession();
}

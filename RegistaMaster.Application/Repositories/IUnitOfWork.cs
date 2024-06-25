namespace RegistaMaster.Application.Repositories;

public interface IUnitOfWork
{
  IBaseRepository BaseRepository { get; }
  ISecurityRepository SecurityRepository { get; }
}

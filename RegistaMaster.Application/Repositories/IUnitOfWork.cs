namespace RegistaMaster.Application.Repositories;

public interface IUnitOfWork
{
  IRepository Repository { get; }
  ISecurityRepository SecurityRepository { get; }
}

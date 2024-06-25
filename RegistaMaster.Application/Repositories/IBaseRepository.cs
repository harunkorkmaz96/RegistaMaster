using RegistaMaster.Domain.Entities;
using System.Linq.Expressions;

namespace RegistaMaster.Application.Repositories;

public interface IBaseRepository
{
  Task<T> Add<T>(T entity) where T : BaseEntity;
  T Update<T>(T entity) where T : BaseEntity;
  Task<T> Delete<T>(int id) where T : BaseEntity;
  Task<ICollection<T>> UpdateRange<T>(ICollection<T> entity) where T : BaseEntity;
  Task <ICollection<T>> DeleteRange<T>(ICollection<T> entity) where T : BaseEntity;
  Task <T> GetById<T>(int id) where T : BaseEntity;
  Task<T> Find<T>(Expression<Func<T, bool>> predicate) where T : BaseEntity;
  IQueryable<T> GetNonDeltedAndActive<T>(Expression<Func<T, bool>> expression) where T : BaseEntity;
  IQueryable<T> GetQueryable<T>(Expression<Func<T, bool>> expression) where T : BaseEntity;
}

using Microsoft.EntityFrameworkCore;
using RegistaMaster.Application.Repositories;
using RegistaMaster.Domain.DTOModels.SecurityModels;
using RegistaMaster.Domain.DTOModels.SelectModels;
using RegistaMaster.Domain.Entities;
using RegistaMaster.Domain.Enums;
using RegistaMaster.Persistance.RegistaMasterContextes;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;

namespace RegistaMaster.Infastructure.Repositories;

public class BaseRepository(SessionDTO session, RegistaMasterContext context) : IBaseRepository
{
  private readonly SessionDTO _session = session;
  private readonly RegistaMasterContext _context = context;
  private DbSet<T> GetTable<T>() where T : BaseEntity
  {
    return _context.Set<T>();
  }
  public async Task<T> Add<T>(T entity) where T : BaseEntity
  {
    entity.CreatedBy = _session.Id;
    entity.LastModifiedBy = _session.Id;
    entity.LastModifiedOn = DateTime.Now;
    entity.CreatedOn = DateTime.Now;
    entity.Status = Status.Active;
    entity.ObjectStatus = ObjectStatus.NonDeleted;
    await GetTable<T>().AddAsync(entity);
    return entity;
  }
  public async Task<T> Delete<T>(int id) where T : BaseEntity
  {
    var entity = await Find<T>(t => t.Id == id);
    await Delete<T>(entity);
    return await Delete(entity);
  }
  public async Task<T> Delete<T>(T entity) where T : BaseEntity
  {
    entity.ObjectStatus = ObjectStatus.Deleted;
    entity.Status = Status.Passive;
    return Update(entity);
  }
  public async Task<ICollection<T>> DeleteRange<T>(ICollection<T> entities) where T : BaseEntity
  {
    foreach (var entity in entities)
    {
      entity.LastModifiedBy = _session.Id;
      entity.LastModifiedOn = DateTime.Now;
      entity.ObjectStatus = ObjectStatus.Deleted;
      entity.Status = Status.Passive;
    }
    GetTable<T>().UpdateRange(entities);
    return entities;
  }
  public T Update<T>(T entity) where T : BaseEntity
  {
    entity.LastModifiedOn = DateTime.Now;
    entity.LastModifiedBy = _session.Id;
    GetTable<T>().Update(entity);
    return entity;
  }
  public async Task<ICollection<T>> UpdateRange<T>(ICollection<T> entities) where T : BaseEntity
  {
    foreach (var entity in entities)
    {
      entity.LastModifiedOn = DateTime.Now;
      entity.LastModifiedBy = _session.Id;
    }

    GetTable<T>().UpdateRange(entities);
    return entities;
  }
  public async Task<T> GetById<T>(int id) where T : BaseEntity
  {
    return await Find<T>(t => t.Id == id);
  }
  public async Task<T> Find<T>(Expression<Func<T, bool>> expression) where T : BaseEntity
  {
    return await GetTable<T>().FirstOrDefaultAsync(expression);
  }
  public IQueryable<T> GetQueryable<T>(Expression<Func<T, bool>> expression) where T : BaseEntity
  {
    return GetTable<T>().Where(expression);
  }
  public IQueryable<T> GetNonDeltedAndActive<T>(Expression<Func<T, bool>> expression) where T : BaseEntity
  {
    return GetQueryable<T>(t => t.ObjectStatus == ObjectStatus.NonDeleted && t.Status == Status.Active).Where(expression);
  }
  public string GetDisplayValue<E>(E value)
  {
    var filedInfo = value.GetType().GetField(value.ToString());
    var descriptionAttirbutes = filedInfo.GetCustomAttributes(
      typeof(DisplayAttribute), false) as DisplayAttribute[];

    if (descriptionAttirbutes[0].ResourceType != null)
      return lookupResource(descriptionAttirbutes[0].ResourceType, descriptionAttirbutes[0].Name);
    if (descriptionAttirbutes == null) return string.Empty;
    return (descriptionAttirbutes.Length > 0) ? descriptionAttirbutes[0].Name : value.ToString();
  }
  public List<SelectDTO> GetEnumSelect<E>()
  {
      return (Enum.GetValues(typeof(E)).Cast<E>().Select(e => new SelectDTO() { Text = GetDisplayValue<E>(e), Value = e.ToString(), Id = Convert.ToInt32(e) })).ToList();
  }
  public string lookupResource(Type resourceManagerProvider, string resourceKey)
  {
    foreach (PropertyInfo staticProperty in resourceManagerProvider.GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public))
    {
      if (staticProperty.PropertyType == typeof(System.Resources.ResourceManager))
      {
        System.Resources.ResourceManager resourceManager = (System.Resources.ResourceManager)staticProperty.GetValue(null, null);
        return resourceManager.GetString(resourceKey);
      }
    }
return resourceKey; // Fallback with the key name
  }
}

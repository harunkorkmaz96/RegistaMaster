using Microsoft.AspNetCore.Mvc.Rendering;
using RegistaMaster.Domain.Enums;

namespace RegistaMaster.Domain.DTOModels.Entities.RequestModels;

public class RequestDTO
{
  public string Subject { get; set; }
  public int ModuleId { get; set; }
  public int Id { get; set; }
  public int VersionId { get; set; }
  public string PageUrl { get; set; }
  public string PictureURL { get; set; }
  public string RequestName { get; set; }
  public string? Description { get; set; }
  public int CustomerId { get; set; }
  public string CustomerName { get; set; }
  public int ProjectId { get; set; }
  public int NotificationTypeId { get; set; }
  public int? CategoryId { get; set; }
  public int LastModifiedBy { get; set; }
  public DateTime? LastModifiedOn { get; set; }
  public DateTime? CretedOn { get; set; }

  public ObjectStatus ObjectStatus { get; set; }
  public Status Status { get; set; }
  public DateTime StartDate { get; set; }
  public DateTime PlanedDate { get; set; }
  public RequestStatus RequestStatus { get; set; }
  public CategoryStatus CategoryStatus { get; set; }

  public List<SelectListItem> Project { get; set; }
  public List<SelectListItem> Responsible { get; set; }
  public List<SelectListItem> NotificationType { get; set; }
  public List<SelectListItem> Category { get; set; }
}

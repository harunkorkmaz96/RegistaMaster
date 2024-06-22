using RegistaMaster.Domain.Entities;
using RegistaMaster.Domain.Enums;

namespace RegistaMaster.Domain.DTOModels.Entities.RequestModels;

public class RequestGridDTO
{
  public int Id { get; set; }
  public int CreatedBy { get; set; }
  public string Subject { get; set; }
  public string Description { get; set; }
  public int? CategoryId { get; set; }
  public int? NotificationTypeId { get; set; }
  public string? PageURL { get; set; }
  public string? PictureURL { get; set; }
  public DateTime StartDate { get; set; }
  public DateTime? CreatedOn { get; set; }
  public DateTime PlanedEndDate { get; set; }
  public RequestStatus RequestStatus { get; set; }
  public int NotificationId { get; set; }
  public int? VersionId { get; set; }
  public int? ModuleId { get; set; }
  public int ProjectId { get; set; }
  public string Color { get; set; }
  public ICollection<RequestFile> Files { get; set; }
}

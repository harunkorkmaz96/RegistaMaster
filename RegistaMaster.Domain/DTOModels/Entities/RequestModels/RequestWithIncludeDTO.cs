using RegistaMaster.Domain.Entities;

namespace RegistaMaster.Domain.DTOModels.Entities.RequestModels;

public class RequestWithIncludeDTO
{
  public string? Subject { get; set; }
  public string? Description { get; set; }
  public string? Category { get; set; }
  public string? NotificationType { get; set; }
  public string? PageURL { get; set; }
  public string? StartDate { get; set; }
  public string? PlanedEndDate { get; set; }
  public string? RequestStatus { get; set; }
  public string? Version { get; set; }
  public string? Module { get; set; }
  public string? Project { get; set; }
  public ICollection<RequestFile>? Files { get; set; }
}

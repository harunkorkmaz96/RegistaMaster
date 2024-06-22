namespace RegistaMaster.Domain.DTOModels.Entities.HealthCheckModels;

public class HealthCheckDTO
{
  public string Status { get; set; }
  public string ProjectKey { get; set; }
  public string RequestDescription { get; set; }
  public DateTime RequestDate { get; set; }
}

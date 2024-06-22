using RegistaMaster.Domain.Enums;

namespace RegistaMaster.Domain.DTOModels.SecurityModels;

public class SesssionDTO
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string SurName { get; set; }
  public string FullName => $"{Name} {SurName}";
  public string Image { get; set; }
  public int CustomerId { get; set; }
  public AuthorizationStatus AuthorizationStatus { get; set; }
}

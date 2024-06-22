namespace RegistaMaster.Domain.DTOModels.Entities.UserModels;

public class UserCreatedByDTO
{
  public string ProjectKey { get; set; }
  public string NameSurName { get; set; }
  public DateTime LoginDate { get; set; }
  public int? ClientId { get; set; }
  public int? MemberId { get; set; }
}

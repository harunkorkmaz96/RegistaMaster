namespace RegistaMaster.Domain.DTOModels.Entities.UserLogModels;

public class UserLogDTO
{
  public string ProjectKey { get; set; }
  public string NameSurName { get; set; }
  public DateTime LoginDate { get; set; }
  public int? ClientId { get; set; }
  public int? MemberId { get; set; }
}

namespace RegistaMaster.Domain.DTOModels.Entities.ErrorLogModels;

public class ErrorLogDTO
{
  public string ProjectKey { get; set; }
  public string NameSurName { get; set; }
  public DateTime ErrorDate { get; set; }
  public string ErrorDescription { get; set; }
  public int ClientId { get; set; }
  public int MemberId { get; set; }
}

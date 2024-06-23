using System.ComponentModel;

namespace RegistaMaster.Domain.Entities;

public class ErrorLog:BaseEntity
{
  [DisplayName("Kullanıcı Adı ve Soyadı")]
  public string NameSurName { get; set; }

  [DisplayName("Hata Tarihi")]
  public DateTime ErrorDate { get; set; }

  [DisplayName("Hata Mesajı")]
  public string ErrorDescription { get; set; }

  [DisplayName("Müşteri")]
  public int ClientId { get; set; }


  [DisplayName("Kullanıcı")]
  public int MemberId { get; set; }

  public int ProjectId { get; set; }
  public Project Project { get; set; }
}

using System.ComponentModel;

namespace RegistaMaster.Domain.Entities;

public class UserLog : BaseEntity
{
  [DisplayName("Ad ve Soyad")]
  public string NameSurName { get; set; }

  [DisplayName("Giriş Yapılan Tarih")]
  public DateTime LoginDate { get; set; }

  [DisplayName("Müşteri ID")]
  public int? ClientId { get; set; }

  [DisplayName("Kullanıcı ID")]
  public int? MemberId { get; set; }

  public int ProjectId { get; set; }
  public Project Project { get; set; }

}

using RegistaMaster.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistaMaster.Domain.Entities;

public class User : BaseEntity
{
  [DisplayName("İsim")]
  [MinLength(3, ErrorMessage = "{0} {1} Karakterden Küçük Olamaz")]
  [MaxLength(150, ErrorMessage = "{0} {1} Karakterden Büyük Olamaz")]
  public string Name { get; set; }

  [DisplayName("Soyisim")]
  [MinLength(3, ErrorMessage = "{0} {1} Karakterden Küçük Olamaz")]
  [MaxLength(150, ErrorMessage = "{0} {1} Karakterden Büyük Olamaz")]
  public string SurName { get; set; }

  [DisplayName("Kullanıcı Adı")]
  public string UserName { get; set; }
  [NotMapped]
  public string FullName => $"{Name} {SurName}";
  public string? Image { get; set; }

  [MinLength(3, ErrorMessage = "{0} {1} Karakterden Küçük Olamaz")]
  [MaxLength(256, ErrorMessage = "{0} {1} Karakterden Büçük Olamaz")]
  [EmailAddress(ErrorMessage = "Geçerli Mail Adresi Giriniz")]
  public string Email { get; set; }
  public string Password { get; set; }
  public AuthorizationStatus AuthorizationStatus { get; set; }
  public virtual Customer Customer { get; set; }
  public int CustomerId { get; set; }
}

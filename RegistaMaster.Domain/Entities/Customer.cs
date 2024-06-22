using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegistaMaster.Domain.Entities;

public class Customer : BaseEntity
{
  [DisplayName("Name")]
  [StringLength(150)]
  [MinLength(3, ErrorMessage = "{0} {1} Karakterden Küçük Olamaz")]
  [MaxLength(150, ErrorMessage = "{0} {1} Karakterden Büyük Olamaz")]
  public string Name { get; set; }

  [DisplayName("Adres")]
  [StringLength(600)]
  [MinLength(3, ErrorMessage = "{0} {1} Karakterden Küçük Olamaz")]
  [MaxLength(150, ErrorMessage = "{0} {1} Karakterden Büyük Olamaz")]
  public string? Adress { get; set; }

  [DisplayName("Email")]
  public string? Email { get; set; }
  public string? ApiKey { get; set; }

  [DisplayName("Müşteri Tanım No")]
  public int? CustomerDescriptionId { get; set; }
  public ICollection<Request> Requests { get; set; }
  public ICollection<ProjectNote> ProjectNotes { get; set; }


}

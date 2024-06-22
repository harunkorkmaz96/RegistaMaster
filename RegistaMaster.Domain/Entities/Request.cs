using RegistaMaster.Domain.Enums;
using System.ComponentModel;

namespace RegistaMaster.Domain.Entities;

public class Request : BaseEntity
{
  [DisplayName("Konu")]
  public string Subject { get; set; }

  [DisplayName("Açıklama")]
  public string? Description { get; set; }

  public string? Category { get; set; }
  public int? CategoryId { get; set; }

  [DisplayName("Bildiirim Türü")]
  public string? NotificationType { get; set; }
  public int? NotificationTypeId { get; set; }

  [DisplayName("Sayfa Linki")]
  public string? PageURL { get; set; }

  [DisplayName("Görüntü")]
  public string? PictureURL { get; set; }

  [DisplayName("Başlangıç Tarihi")]
  public DateTime StartDate { get; set; }

  [DisplayName("Planlanan Bitiş Tarihi")]
  public DateTime PlanedEndDate { get; set; }

  [DisplayName("Durum")]
  public RequestStatus RequestStatus { get; set; }

  [DisplayName("Bildirim ID")]
  public int NotificationId { get; set; }

  [DisplayName("Version")]
  public int? VeriosId { get; set; }
  public Version Version { get; set; }
  public int? ModuleId { get; set; }
  public int ProjectId { get; set; }
  public Project Project { get; set; }

  public ICollection<Action> Actions { get; set; }
  public ICollection<RequestFile> Files { get; set; }










}

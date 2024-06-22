using System.ComponentModel.DataAnnotations;

namespace RegistaMaster.Domain.Enums;

public enum NotificationTypeCNC
{
  [Display(Name = "Öneri")]
  Suggestion = 0,
  [Display(Name = "Hata")]
  Error = 1,
}

using System.ComponentModel.DataAnnotations;

namespace RegistaMaster.Domain.Enums;

public enum PriorityStatus
{
  [Display(Name = "Düşük")]
  Low = 0,
  [Display(Name = "Orta")]
  Middle = 1,
  [Display(Name = "Yüksek")]
  High = 2,
}

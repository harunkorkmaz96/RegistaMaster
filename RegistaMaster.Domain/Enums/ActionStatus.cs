using System.ComponentModel.DataAnnotations;

namespace RegistaMaster.Domain.Enums;

public enum ActionStatus
{
  [Display(Name ="Başlamadı")]
  notStarted=0,
  [Display(Name = "Devam Ediyor")]
  Contiuned= 0,
  [Display(Name = "Tamamlandı")]
  Completed = 0,
  [Display(Name = "İptal/Reddedildi")]
  Cancel = 0,

}

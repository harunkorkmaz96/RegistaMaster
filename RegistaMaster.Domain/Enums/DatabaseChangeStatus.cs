using System.ComponentModel.DataAnnotations;

namespace RegistaMaster.Domain.Enums;

public enum DatabaseChangeStatus
{
  [Display(Name ="Evet")]
  Yes=0,
  [Display(Name = "Hayır")]
  No= 1,
}

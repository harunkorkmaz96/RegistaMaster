using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegistaMaster.Domain.Enums;

public enum AuthorizationStatus
{
  [Display(Name = "Admin")]
  Admin = 0,
  [Display(Name = "TeamLeader")]
  TeamLeader= 1,
  [Display(Name = "Developer")]
  Developer= 2,
}

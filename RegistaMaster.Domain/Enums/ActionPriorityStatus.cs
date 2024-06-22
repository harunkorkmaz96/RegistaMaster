﻿using System.ComponentModel.DataAnnotations;

namespace RegistaMaster.Domain.Enums;

public enum ActionPriorityStatus
{
  [Display(Name = "Öncelik Belirtilmedi")]
  NotSpecified = 0,
  [Display(Name = "1")]
  Priority1 = 1,
  [Display(Name = "2")]
  Priority2 = 2,
  [Display(Name = "3")]
  Priority3 = 3,
}

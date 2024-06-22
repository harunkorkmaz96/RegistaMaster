﻿using System.ComponentModel;

namespace RegistaMaster.Domain.Entities;

public class Module:BaseEntity
{
  [DisplayName("Modül Adı")]
  public string Name { get; set; }
  [DisplayName("Modül Açıklaması")]
  public string? Description { get; set; }
  public int ProjectId { get; set; }
  public Project Project { get; set; }

}

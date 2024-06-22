﻿namespace RegistaMaster.Domain.Entities;

public class EmailInformation : BaseEntity
{
  public string? EmailHost { get; set; }
  public string? EmailPort { get; set; }
  public bool EnableSsl { get; set; }
  public string? EmailPassword { get; set; }
  public string? ContactEmail { get; set; }
  public int CustomerId { get; set; }
  public Customer Customer { get; set; }
}

﻿namespace RegistaMaster.Domain.Entities;

public class Version:BaseEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public bool DataBaseChange { get; set; }
    public int ProjectId{ get; set; }
    public Project Project { get; set; }
}

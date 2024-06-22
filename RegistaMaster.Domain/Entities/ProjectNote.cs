﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegistaMaster.Domain.Entities;

public class ProjectNote:BaseEntity
{
  [DisplayName("Tarih")]
  [DataType(DataType.DateTime)]
  public DateTime Date { get; set; }

  [DisplayName("Tür")]
  [Required(AllowEmptyStrings = false, ErrorMessage = "{0} Doldurulması Zorunludur")]
  [DataType(DataType.Text)]
  public string? NoteType { get; set; }

  [DisplayName("Açıklama")]
  [Required(AllowEmptyStrings = false, ErrorMessage = "{0} Doldurulması Zorunludur")]
  [DataType(DataType.Text)]
  public string? Description { get; set; }
  public int? ProjectId { get; set; }
  public Project Project { get; set; }
}

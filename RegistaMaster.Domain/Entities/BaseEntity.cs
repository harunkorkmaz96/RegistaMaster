﻿using RegistaMaster.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistaMaster.Domain.Entities;

public class BaseEntity
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }
  [DisplayName("Oluşturulma Tarihi")]
  public DateTime? CreatedOn { get; set; }

  [DisplayName("Güncelleme Tarihi")]
  public DateTime? LastModifiedOn { get; set; }

  [DisplayName("Oluşturan Kullanıcı")]
  public int CreatedBy { get; set; }

  [DisplayName("Güncelleyen Kullanıcı")]
  public int LastModifedBy { get; set; }

  [DisplayName("Silindi Bilgisi")]
  [DefaultValue(0)]
  public ObjectStatus ObjectStatus { get; set; }

  [DisplayName("Durum")]
  [DefaultValue(1)]
  public Status Status { get; set; }
}

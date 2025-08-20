using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("PhysicalDocumentConfig")]
public partial class PhysicalDocumentConfig
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    public int? AdjustmentCount { get; set; }

    public bool? ShowAllForSecond { get; set; }

    public bool? ShowAllForThird { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("IdsNavigation")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}

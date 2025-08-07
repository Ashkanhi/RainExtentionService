using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "Id", "ReasonId")]
[Table("PeriodicCostingExtend")]
public partial class PeriodicCostingExtend
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("ReasonID")]
    public int ReasonId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [StringLength(10)]
    public string? Description { get; set; }

    [Column("StepID")]
    public Guid? StepId { get; set; }

    [ForeignKey("BookerStoreId, Id")]
    [InverseProperty("PeriodicCostingExtends")]
    public virtual PeriodicCosting PeriodicCosting { get; set; } = null!;

    [ForeignKey("ReasonId")]
    [InverseProperty("PeriodicCostingExtends")]
    public virtual Reason Reason { get; set; } = null!;

    [ForeignKey("StepId")]
    [InverseProperty("PeriodicCostingExtends")]
    public virtual ProductionStep? Step { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "ChildId", "StepId")]
[Table("BillOfMaterialItemStep")]
public partial class BillOfMaterialItemStep
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("ChildID")]
    public Guid ChildId { get; set; }

    [Key]
    [Column("StepID")]
    public Guid StepId { get; set; }

    public int? StepOrder { get; set; }

    [ForeignKey("Id, ChildId")]
    [InverseProperty("BillOfMaterialItemSteps")]
    public virtual BillOfMaterialItem BillOfMaterialItem { get; set; } = null!;

    [ForeignKey("ChildId")]
    [InverseProperty("BillOfMaterialItemSteps")]
    public virtual Item Child { get; set; } = null!;

    [ForeignKey("StepId")]
    [InverseProperty("BillOfMaterialItemSteps")]
    public virtual ProductionStep Step { get; set; } = null!;
}

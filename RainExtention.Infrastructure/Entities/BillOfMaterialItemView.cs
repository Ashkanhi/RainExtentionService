using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class BillOfMaterialItemView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ChildID")]
    public Guid ChildId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Weight { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [Column("StepID")]
    public Guid? StepId { get; set; }

    [Column("SecondStepID")]
    public Guid? SecondStepId { get; set; }

    [Column("ThirdStepID")]
    public Guid? ThirdStepId { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ItemDepartmentView
{
    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    public bool? Taxable { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TollAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CommissionPercent { get; set; }

    [Column("OwnerGroupID")]
    public Guid? OwnerGroupId { get; set; }

    public byte[]? Image { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [StringLength(50)]
    public string? DepartmentCode { get; set; }

    [Column("LevelID")]
    public int? LevelId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxUsageAmount { get; set; }

    public bool? ShowInVitrin { get; set; }

    [StringLength(124)]
    public string? ImageUrl { get; set; }
}

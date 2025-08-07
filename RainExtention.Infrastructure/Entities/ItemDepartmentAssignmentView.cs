using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ItemDepartmentAssignmentView
{
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column("TypeID")]
    public int TypeId { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? DepartmentCode { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CommissionPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxUsageAmount { get; set; }

    public bool? Taxable { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TollAmount { get; set; }
}

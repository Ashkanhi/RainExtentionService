using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ProductionPlanDepartmentView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? UnitCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? EstimateCostPerUnit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? EstimatePricePerUnit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ModelCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SizeCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ColorCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SerieCount { get; set; }

    [StringLength(100)]
    public string? DepartmentName { get; set; }
}

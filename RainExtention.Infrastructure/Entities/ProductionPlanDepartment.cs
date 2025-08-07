using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "DepartmentId")]
[Table("ProductionPlanDepartment")]
public partial class ProductionPlanDepartment
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
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

    [ForeignKey("DepartmentId")]
    [InverseProperty("ProductionPlanDepartments")]
    public virtual Department Department { get; set; } = null!;

    [ForeignKey("Id")]
    [InverseProperty("ProductionPlanDepartments")]
    public virtual ProductionPlan IdNavigation { get; set; } = null!;
}

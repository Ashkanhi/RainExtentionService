using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ProductCatalogStep")]
public partial class ProductCatalogStep
{
    [Key]
    [Column("StepID")]
    public int StepId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column("PermissionID")]
    public int? PermissionId { get; set; }

    [Column("OrderID")]
    public int? OrderId { get; set; }

    [Column("ParentStepID")]
    public int? ParentStepId { get; set; }

    [ForeignKey("PermissionId")]
    [InverseProperty("ProductCatalogSteps")]
    public virtual Permission? Permission { get; set; }

    [InverseProperty("Step")]
    public virtual ICollection<ProductCatalogDetail> ProductCatalogDetails { get; set; } = new List<ProductCatalogDetail>();

    [ForeignKey("StepId")]
    [InverseProperty("Steps")]
    public virtual ICollection<ProductCatalog> Catalogs { get; set; } = new List<ProductCatalog>();

    [ForeignKey("StepId")]
    [InverseProperty("Steps")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}

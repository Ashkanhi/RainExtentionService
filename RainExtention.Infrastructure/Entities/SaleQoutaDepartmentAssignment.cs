using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("QoutaId", "DepartmentId")]
[Table("SaleQoutaDepartmentAssignment")]
public partial class SaleQoutaDepartmentAssignment
{
    [Key]
    [Column("QoutaID")]
    public Guid QoutaId { get; set; }

    [Key]
    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxAmount { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("SaleQoutaDepartmentAssignments")]
    public virtual Department Department { get; set; } = null!;

    [ForeignKey("QoutaId")]
    [InverseProperty("SaleQoutaDepartmentAssignments")]
    public virtual SaleQoutum Qouta { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("DiscountId", "DepartmentId")]
[Table("DiscountDepartmentAssignment")]
public partial class DiscountDepartmentAssignment
{
    [Key]
    [Column("DiscountID")]
    public Guid DiscountId { get; set; }

    [Key]
    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SupplierDiscount { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("DiscountDepartmentAssignments")]
    public virtual Department Department { get; set; } = null!;

    [ForeignKey("DiscountId")]
    [InverseProperty("DiscountDepartmentAssignments")]
    public virtual Discount Discount { get; set; } = null!;
}

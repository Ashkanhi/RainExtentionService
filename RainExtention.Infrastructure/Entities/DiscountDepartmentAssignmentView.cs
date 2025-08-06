using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class DiscountDepartmentAssignmentView
{
    [Column("DiscountID")]
    public Guid DiscountId { get; set; }

    [Column("DepartmentID")]
    public Guid DepartmentId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SupplierDiscount { get; set; }

    [StringLength(100)]
    public string? DepartmentName { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class LastWeekDepartmentSale
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [StringLength(100)]
    public string DepartmentName { get; set; } = null!;

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? TotalAmount { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? TollAmount { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? ExpectedAmount { get; set; }
}

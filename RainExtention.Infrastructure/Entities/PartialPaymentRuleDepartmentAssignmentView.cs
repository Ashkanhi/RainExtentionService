using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class PartialPaymentRuleDepartmentAssignmentView
{
    [Column("RuleID")]
    public Guid RuleId { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    public int? PaymentCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? WageAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ProfitPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PrePaidPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxPayableAmount { get; set; }

    [StringLength(100)]
    public string? DepartmentName { get; set; }
}

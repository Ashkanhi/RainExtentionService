using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("RuleId", "LineItemId")]
[Table("PartialPaymentRuleDepartmentAssignment")]
public partial class PartialPaymentRuleDepartmentAssignment
{
    [Key]
    [Column("RuleID")]
    public Guid RuleId { get; set; }

    [Key]
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

    [ForeignKey("DepartmentId")]
    [InverseProperty("PartialPaymentRuleDepartmentAssignments")]
    public virtual Department? Department { get; set; }

    [ForeignKey("RuleId")]
    [InverseProperty("PartialPaymentRuleDepartmentAssignments")]
    public virtual PartialPaymentRule Rule { get; set; } = null!;
}

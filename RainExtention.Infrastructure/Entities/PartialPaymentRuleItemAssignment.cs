using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("RuleId", "LineItemId")]
[Table("PartialPaymentRuleItemAssignment")]
public partial class PartialPaymentRuleItemAssignment
{
    [Key]
    [Column("RuleID")]
    public Guid RuleId { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    public int? PaymentCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? WageAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ProfitPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PrePaidPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxPayableAmount { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("PartialPaymentRuleItemAssignments")]
    public virtual Item? Item { get; set; }

    [ForeignKey("RuleId")]
    [InverseProperty("PartialPaymentRuleItemAssignments")]
    public virtual PartialPaymentRule Rule { get; set; } = null!;
}

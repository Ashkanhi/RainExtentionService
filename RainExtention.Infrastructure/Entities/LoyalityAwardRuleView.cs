using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class LoyalityAwardRuleView
{
    [Column("RuleID")]
    public Guid RuleId { get; set; }

    [Column("CustomerGroupID")]
    public Guid? CustomerGroupId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Threshold { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Percent { get; set; }

    public int? ExpireTime { get; set; }

    public int? ExpireMode { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PointToCredit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CreditAmount { get; set; }

    public bool? AllowDiscountItems { get; set; }

    public bool? DownGradeOnExpire { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public int? AgentPointForFirstPurchase { get; set; }

    public int? AgentPointForNextPurchase { get; set; }

    [StringLength(50)]
    public string? CustomerGroupName { get; set; }
}

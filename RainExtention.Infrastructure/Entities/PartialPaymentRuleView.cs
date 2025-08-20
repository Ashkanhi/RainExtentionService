using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class PartialPaymentRuleView
{
    [Column("RuleID")]
    public Guid RuleId { get; set; }

    [StringLength(50)]
    public string? DocumentCode { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PrePaidPercent { get; set; }

    public int? PaymentCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? WageAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ProfitPercent { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApproveDate { get; set; }

    public Guid? ApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoidDate { get; set; }

    public Guid? VoidUser { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxPayableAmount { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}

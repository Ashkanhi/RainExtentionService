using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("PartialPaymentRule")]
public partial class PartialPaymentRule
{
    [Key]
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

    [ForeignKey("ApproveUser")]
    [InverseProperty("PartialPaymentRuleApproveUserNavigations")]
    public virtual User? ApproveUserNavigation { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("PartialPaymentRuleCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [InverseProperty("Rule")]
    public virtual ICollection<PartialPaymentRuleDepartmentAssignment> PartialPaymentRuleDepartmentAssignments { get; set; } = new List<PartialPaymentRuleDepartmentAssignment>();

    [InverseProperty("Rule")]
    public virtual ICollection<PartialPaymentRuleItemAssignment> PartialPaymentRuleItemAssignments { get; set; } = new List<PartialPaymentRuleItemAssignment>();

    [ForeignKey("StatusId")]
    [InverseProperty("PartialPaymentRules")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("VoidUser")]
    [InverseProperty("PartialPaymentRuleVoidUserNavigations")]
    public virtual User? VoidUserNavigation { get; set; }

    [ForeignKey("RuleId")]
    [InverseProperty("Rules")]
    public virtual ICollection<CustomerGroup> CustomerGroups { get; set; } = new List<CustomerGroup>();

    [ForeignKey("RuleId")]
    [InverseProperty("Rules")]
    public virtual ICollection<StoreGroup> StoreGroups { get; set; } = new List<StoreGroup>();

    [ForeignKey("RuleId")]
    [InverseProperty("RulesNavigation")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}

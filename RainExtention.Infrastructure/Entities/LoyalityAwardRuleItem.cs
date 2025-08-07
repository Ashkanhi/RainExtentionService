using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("RuleId", "ItemId")]
public partial class LoyalityAwardRuleItem
{
    [Key]
    [Column("RuleID")]
    public Guid RuleId { get; set; }

    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    public int? Point { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("LoyalityAwardRuleItems")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("RuleId")]
    [InverseProperty("LoyalityAwardRuleItems")]
    public virtual LoyalityAwardRule Rule { get; set; } = null!;
}

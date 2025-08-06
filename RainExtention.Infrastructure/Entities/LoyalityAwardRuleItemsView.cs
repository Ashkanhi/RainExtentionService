using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class LoyalityAwardRuleItemsView
{
    [Column("RuleID")]
    public Guid RuleId { get; set; }

    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    public int? Point { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    public byte[]? ItemImage { get; set; }
}

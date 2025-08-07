using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ItemId", "RuleId")]
[Table("ItemServiceRule")]
public partial class ItemServiceRule
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Key]
    [Column("RuleID")]
    public int RuleId { get; set; }

    public int? ServiceTime { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemServiceRules")]
    public virtual Item Item { get; set; } = null!;
}

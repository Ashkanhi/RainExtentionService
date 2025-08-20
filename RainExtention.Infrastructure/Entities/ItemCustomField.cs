using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ItemCustomField")]
public partial class ItemCustomField
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column("QTY", TypeName = "decimal(18, 3)")]
    public decimal? Qty { get; set; }

    [Column("CommodityID")]
    [StringLength(100)]
    public string? CommodityId { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemCustomField")]
    public virtual Item Item { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ItemId", "StockId")]
[Table("ItemStockQuantity")]
public partial class ItemStockQuantity
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Key]
    [Column("StockID")]
    public Guid StockId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentUnitCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ReservedUnitCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? InTransferUnitCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentUnitCost { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemStockQuantities")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("StockId")]
    [InverseProperty("ItemStockQuantities")]
    public virtual Stock Stock { get; set; } = null!;
}

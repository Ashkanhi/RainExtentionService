using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ItemId", "StoreId")]
[Table("ShelfPricePrint")]
public partial class ShelfPricePrint
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Key]
    [Column("StoreID")]
    public int StoreId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintTime { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SalePrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    public Guid? LastUser { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ShelfPricePrints")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("LastUser")]
    [InverseProperty("ShelfPricePrints")]
    public virtual User? LastUserNavigation { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("ShelfPricePrints")]
    public virtual Store Store { get; set; } = null!;
}

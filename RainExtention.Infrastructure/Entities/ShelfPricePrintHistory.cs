using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ShelfPricePrintHistory")]
[Index("StoreId", Name = "IX_Store")]
[Index("PrintTime", Name = "IX_Time")]
[Index("UserId", Name = "IX_User")]
public partial class ShelfPricePrintHistory
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

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

    [Column("UserID")]
    public Guid? UserId { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ShelfPricePrintHistories")]
    public virtual Item? Item { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("ShelfPricePrintHistories")]
    public virtual Store? Store { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("ShelfPricePrintHistories")]
    public virtual User? User { get; set; }
}

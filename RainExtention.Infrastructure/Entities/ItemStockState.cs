using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ItemId", "StockId")]
[Table("ItemStockState")]
public partial class ItemStockState
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Key]
    [Column("StockID")]
    public Guid StockId { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? PointOfOrder { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? BestOrder { get; set; }

    public bool? RecieveOrderOverage { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? OrderOverageCount { get; set; }

    public bool? AllowSale { get; set; }

    public bool? AllowRecieve { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public bool? AllowOrder { get; set; }

    public bool? AllowReturn { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxOrder { get; set; }

    public int? MinAgeQuantity { get; set; }

    public int? MaxAgeQuantity { get; set; }

    public int? MinAgeSupply { get; set; }

    public int? MaxAgeSupply { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public DateOnly? MaxQuantityDate { get; set; }

    public bool? AllowOnlineSale { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OnlineSaleMargin { get; set; }

    public bool? AllowChangePrice { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemStockStates")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("ItemStockStates")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("StockId")]
    [InverseProperty("ItemStockStates")]
    public virtual Stock Stock { get; set; } = null!;
}

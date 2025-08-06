using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ItemState")]
public partial class ItemState
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PointOfOrder { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? BestOrder { get; set; }

    public bool? RecieveOrderOverage { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OrderOverageCount { get; set; }

    public bool? AllowSale { get; set; }

    public bool? AllowRecieve { get; set; }

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
    [InverseProperty("ItemState")]
    public virtual Item Item { get; set; } = null!;
}

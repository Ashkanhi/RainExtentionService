using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ItemStockStateView
{
    [Column("ItemID")]
    public Guid ItemId { get; set; }

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

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? PointOfOrder { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? BestOrder { get; set; }

    public bool? RecieveOrderOverage { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
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

    [Column("StatusID")]
    public int? StatusId { get; set; }
}

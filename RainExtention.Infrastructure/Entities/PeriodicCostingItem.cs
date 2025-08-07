using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "Id", "ItemId")]
public partial class PeriodicCostingItem
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? BeginQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? BeginCost { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? BuyQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? BuyCost { get; set; }

    [Column("RTVQuantity", TypeName = "decimal(18, 3)")]
    public decimal? Rtvquantity { get; set; }

    [Column("RTVCost", TypeName = "decimal(18, 3)")]
    public decimal? Rtvcost { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SaleQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SaleCost { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ReturnQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ReturnCost { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AdjustQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AdjustCost { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? EndQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? EndCost { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? NetCost { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Fact { get; set; }

    [ForeignKey("BookerStoreId, Id")]
    [InverseProperty("PeriodicCostingItems")]
    public virtual PeriodicCosting PeriodicCosting { get; set; } = null!;
}

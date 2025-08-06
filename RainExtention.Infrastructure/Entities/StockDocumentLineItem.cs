using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId")]
[Table("StockDocumentLineItem")]
[Index("ItemId", Name = "IX_ItemID")]
public partial class StockDocumentLineItem
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Key]
    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? LastUnitCount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? ScannedCount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? PackUnitCount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? PackCount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? UnitCount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? DamagedCount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? BonusCount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? RemindCount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Cost { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Tax { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Toll { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? PositiveCost { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? NegativeCost { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? NetCost { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? SalePrice { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Count1 { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Count2 { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Count3 { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? SupplierCost { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? SupplierDiscount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? DiscountPercent { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? SupplierDiscountPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SourceUnitCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SourcePrice { get; set; }

    public DateOnly? DocumentDate { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("StockDocumentLineItems")]
    public virtual Item? Item { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId")]
    [InverseProperty("StockDocumentLineItems")]
    public virtual StockDocument StockDocument { get; set; } = null!;

    [InverseProperty("StockDocumentLineItem")]
    public virtual StockDocumentLineItemContract? StockDocumentLineItemContract { get; set; }

    [InverseProperty("StockDocumentLineItem")]
    public virtual StockDocumentLineItemCustomDiscount? StockDocumentLineItemCustomDiscount { get; set; }

    [InverseProperty("StockDocumentLineItem")]
    public virtual StockDocumentLineItemCustomField? StockDocumentLineItemCustomField { get; set; }

    [InverseProperty("StockDocumentLineItem")]
    public virtual StockDocumentLineItemExpiration? StockDocumentLineItemExpiration { get; set; }

    [InverseProperty("StockDocumentLineItem")]
    public virtual StockDocumentLineItemReference? StockDocumentLineItemReference { get; set; }

    [InverseProperty("StockDocumentLineItem")]
    public virtual ICollection<StockDocumentLineItemSerial> StockDocumentLineItemSerials { get; set; } = new List<StockDocumentLineItemSerial>();

    [InverseProperty("StockDocumentLineItem")]
    public virtual StockDocumentLineItemTracking? StockDocumentLineItemTracking { get; set; }

    [InverseProperty("StockDocumentLineItem")]
    public virtual StockDocumentOrderReference? StockDocumentOrderReference { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class StockDocumentLineItemView
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

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

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    public bool? AllowSerial { get; set; }

    [StringLength(50)]
    public string? UnitOfMeasure { get; set; }

    [StringLength(100)]
    public string? DepartmentName { get; set; }

    [Column("TaxGroupID")]
    public Guid? TaxGroupId { get; set; }

    [StringLength(100)]
    public string? TaxGroupName { get; set; }

    [Column("DiscountGroupID")]
    public Guid? DiscountGroupId { get; set; }

    [StringLength(100)]
    public string? DiscountGroupName { get; set; }

    [StringLength(100)]
    public string? ReportGroupName { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentDiscount { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    [Column("ContractTypeID")]
    public int? ContractTypeId { get; set; }

    [StringLength(50)]
    public string? ContractNumber { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ContractConsumerPrice { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}

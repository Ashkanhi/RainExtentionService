using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ReturnInvoiceLineItemView
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Column("InvoiceID")]
    public Guid InvoiceId { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OldQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OrderQuantity { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? BonusQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PriceAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TollAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ManufacturerPrice { get; set; }

    public bool? IsDelivery { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RoundAmount { get; set; }

    public byte? RoundType { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Point { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentPrice { get; set; }

    public bool? IsManualDiscount { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    public byte[]? ItemImage { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? InvoiceDiscount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? InvoiceDiscountPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ManualDiscount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ManualDiscountPercent { get; set; }

    public bool? IsPriceWithTax { get; set; }

    public bool? IsTaxAsDiscount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ServiceAmount { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public bool Taxable { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TaxPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TollPercent { get; set; }

    [StringLength(50)]
    public string? SerialNumber { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}

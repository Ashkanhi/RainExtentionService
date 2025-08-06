using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "LineItemId")]
[Table("SaleInvoiceLineItem")]
[Index("IsDelivery", Name = "IX_IsDelivery")]
[Index("IsManualDiscount", Name = "IX_IsManualDiscount")]
[Index("IsPriceWithTax", Name = "IX_IsPriceWithTax")]
[Index("ItemId", Name = "IX_Item")]
[Index("ReasonId", Name = "IX_ReasonID")]
[Index("RoundType", Name = "IX_RoundType")]
[Index("StatusId", Name = "IX_StatusID")]
[Index("TypeId", Name = "IX_TypeID")]
public partial class SaleInvoiceLineItem
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Key]
    [Column("InvoiceID")]
    public Guid InvoiceId { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? BonusQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PriceAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? InvoiceDiscount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? InvoiceDiscountPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TollAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RoundAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ManufacturerPrice { get; set; }

    public bool? IsDelivery { get; set; }

    [Column("ReasonID")]
    public int? ReasonId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SupplierDiscount { get; set; }

    public bool? IsPriceWithTax { get; set; }

    public bool? IsManualDiscount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerPrice { get; set; }

    public byte? RoundType { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ManualDiscount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ManualDiscountPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Point { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OrderQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ServiceAmount { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public bool? IsTaxAsDiscount { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("SaleInvoiceLineItems")]
    public virtual Item? Item { get; set; }

    [ForeignKey("ReasonId")]
    [InverseProperty("SaleInvoiceLineItems")]
    public virtual Reason? Reason { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId")]
    [InverseProperty("SaleInvoiceLineItems")]
    public virtual SaleInvoice SaleInvoice { get; set; } = null!;

    [InverseProperty("SaleInvoiceLineItem")]
    public virtual ICollection<SaleInvoiceLineItemContract> SaleInvoiceLineItemContracts { get; set; } = new List<SaleInvoiceLineItemContract>();

    [InverseProperty("SaleInvoiceLineItem")]
    public virtual SaleInvoiceLineItemCustomField? SaleInvoiceLineItemCustomField { get; set; }

    [InverseProperty("SaleInvoiceLineItem")]
    public virtual ICollection<SaleInvoiceLineItemDetail> SaleInvoiceLineItemDetails { get; set; } = new List<SaleInvoiceLineItemDetail>();

    [InverseProperty("SaleInvoiceLineItem")]
    public virtual SaleInvoiceLineItemPartialPayment? SaleInvoiceLineItemPartialPayment { get; set; }

    [InverseProperty("SaleInvoiceLineItem")]
    public virtual SaleInvoiceLineItemReference? SaleInvoiceLineItemReference { get; set; }

    [InverseProperty("SaleInvoiceLineItem")]
    public virtual ICollection<SaleInvoiceLineItemSalePerson> SaleInvoiceLineItemSalePeople { get; set; } = new List<SaleInvoiceLineItemSalePerson>();

    [InverseProperty("SaleInvoiceLineItem")]
    public virtual SaleInvoiceLineItemTracking? SaleInvoiceLineItemTracking { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("SaleInvoiceLineItemStatuses")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("TypeId")]
    [InverseProperty("SaleInvoiceLineItemTypes")]
    public virtual Dictionary? Type { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "LineItemId", "DetailId")]
[Table("SaleInvoiceLineItemDetail")]
public partial class SaleInvoiceLineItemDetail
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

    [Key]
    [Column("DetailID")]
    public int DetailId { get; set; }

    [Column("ParentItemID")]
    public Guid? ParentItemId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? PriceAmount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? TollAmount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? ExpectedAmount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? NetCost { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? DiscountPercent { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? RoundAmount { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("SaleInvoiceLineItemDetailItems")]
    public virtual Item? Item { get; set; }

    [ForeignKey("ParentItemId")]
    [InverseProperty("SaleInvoiceLineItemDetailParentItems")]
    public virtual Item? ParentItem { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId, LineItemId")]
    [InverseProperty("SaleInvoiceLineItemDetails")]
    public virtual SaleInvoiceLineItem SaleInvoiceLineItem { get; set; } = null!;
}

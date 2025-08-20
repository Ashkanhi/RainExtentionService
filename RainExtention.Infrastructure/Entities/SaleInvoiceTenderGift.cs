using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "LineItemId")]
[Table("SaleInvoiceTenderGift")]
public partial class SaleInvoiceTenderGift
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

    [Column("GiftCardID")]
    public Guid? GiftCardId { get; set; }

    [StringLength(100)]
    public string? SerialNumber { get; set; }

    [Column("ReasonID")]
    public int? ReasonId { get; set; }

    public int? Quantity { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId, LineItemId")]
    [InverseProperty("SaleInvoiceTenderGift")]
    public virtual SaleInvoiceTender SaleInvoiceTender { get; set; } = null!;
}

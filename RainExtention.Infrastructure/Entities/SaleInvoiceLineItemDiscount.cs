using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("SaleInvoiceLineItemDiscount")]
public partial class SaleInvoiceLineItemDiscount
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Column("InvoiceID")]
    public Guid InvoiceId { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("DetailID")]
    public int DetailId { get; set; }

    [Column("DiscountID")]
    public Guid? DiscountId { get; set; }

    [Column("ReasonID")]
    public int? ReasonId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountPercent { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? NetDiscountAmount { get; set; }
}

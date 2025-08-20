using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId")]
[Table("SaleInvoiceCustomDiscount")]
public partial class SaleInvoiceCustomDiscount
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

    [Column("ReasonID")]
    public int? ReasonId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountPercent { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId")]
    [InverseProperty("SaleInvoiceCustomDiscount")]
    public virtual SaleInvoice SaleInvoice { get; set; } = null!;
}

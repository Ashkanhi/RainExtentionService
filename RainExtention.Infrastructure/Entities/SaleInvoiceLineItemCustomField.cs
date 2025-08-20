using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "LineItemId")]
[Table("SaleInvoiceLineItemCustomField")]
public partial class SaleInvoiceLineItemCustomField
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

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId, LineItemId")]
    [InverseProperty("SaleInvoiceLineItemCustomField")]
    public virtual SaleInvoiceLineItem SaleInvoiceLineItem { get; set; } = null!;
}

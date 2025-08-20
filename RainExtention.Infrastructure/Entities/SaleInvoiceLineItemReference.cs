using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "LineItemId")]
[Table("SaleInvoiceLineItemReference")]
[Index("ReferStoreId", "ReferWorkstationId", "ReferInvoiceId", "ReferLineItemId", Name = "IX_SaleInvoiceLineItemReference")]
public partial class SaleInvoiceLineItemReference
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

    [Column("ReferStoreID")]
    public int? ReferStoreId { get; set; }

    [Column("ReferWorkstationID")]
    public int? ReferWorkstationId { get; set; }

    [Column("ReferInvoiceID")]
    public Guid? ReferInvoiceId { get; set; }

    [Column("ReferLineItemID")]
    public int? ReferLineItemId { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId, LineItemId")]
    [InverseProperty("SaleInvoiceLineItemReference")]
    public virtual SaleInvoiceLineItem SaleInvoiceLineItem { get; set; } = null!;
}

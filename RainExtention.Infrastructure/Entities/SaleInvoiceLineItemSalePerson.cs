using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "LineItemId", "SalePersonId")]
[Table("SaleInvoiceLineItemSalePerson")]
public partial class SaleInvoiceLineItemSalePerson
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
    [Column("SalePersonID")]
    public Guid SalePersonId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ComissionPercent { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId, LineItemId")]
    [InverseProperty("SaleInvoiceLineItemSalePeople")]
    public virtual SaleInvoiceLineItem SaleInvoiceLineItem { get; set; } = null!;

    [ForeignKey("SalePersonId")]
    [InverseProperty("SaleInvoiceLineItemSalePeople")]
    public virtual Employee SalePerson { get; set; } = null!;
}

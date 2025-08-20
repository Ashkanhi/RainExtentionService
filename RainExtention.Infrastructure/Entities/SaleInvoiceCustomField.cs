using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId")]
[Table("SaleInvoiceCustomField")]
public partial class SaleInvoiceCustomField
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

    [StringLength(100)]
    public string? TaxInnoNumber { get; set; }

    [Column("IrtaxID")]
    [StringLength(100)]
    public string? IrtaxId { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId")]
    [InverseProperty("SaleInvoiceCustomField")]
    public virtual SaleInvoice SaleInvoice { get; set; } = null!;
}

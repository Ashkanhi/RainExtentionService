using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "TypeId")]
[Table("SaleInvoiceTaxReference")]
public partial class SaleInvoiceTaxReference
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
    [Column("TypeID")]
    public int TypeId { get; set; }

    [Column("UID")]
    [StringLength(50)]
    public string? Uid { get; set; }

    [Column("FiscalID")]
    [StringLength(50)]
    public string? FiscalId { get; set; }

    [StringLength(50)]
    public string? ReferenceNumber { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId")]
    [InverseProperty("SaleInvoiceTaxReferences")]
    public virtual SaleInvoice SaleInvoice { get; set; } = null!;
}

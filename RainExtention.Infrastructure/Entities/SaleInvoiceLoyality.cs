using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId")]
[Table("SaleInvoiceLoyality")]
public partial class SaleInvoiceLoyality
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

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AcceptedPoint { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AcceptedCredit { get; set; }

    public bool? PointCalculate { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId")]
    [InverseProperty("SaleInvoiceLoyality")]
    public virtual SaleInvoice SaleInvoice { get; set; } = null!;
}

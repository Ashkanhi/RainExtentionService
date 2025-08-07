using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "LineItemId")]
[Table("SaleInvoiceService")]
public partial class SaleInvoiceService
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

    public Guid? ServiceId { get; set; }

    [Column("OperatorID")]
    public Guid? OperatorId { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Price { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? TollAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [ForeignKey("OperatorId")]
    [InverseProperty("SaleInvoiceServices")]
    public virtual Employee? Operator { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId")]
    [InverseProperty("SaleInvoiceServices")]
    public virtual SaleInvoice SaleInvoice { get; set; } = null!;

    [ForeignKey("ServiceId")]
    [InverseProperty("SaleInvoiceServices")]
    public virtual ServiceItem? Service { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "LineItemId")]
[Table("SaleInvoiceTenderPOS")]
public partial class SaleInvoiceTenderPo
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

    [Column("TerminalID")]
    [StringLength(50)]
    public string? TerminalId { get; set; }

    [Column("PANNumber")]
    [StringLength(100)]
    public string? Pannumber { get; set; }

    [StringLength(50)]
    public string? RefrenceNumber { get; set; }

    [Column("SVCNumber")]
    [StringLength(50)]
    public string? Svcnumber { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountAmount { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId, LineItemId")]
    [InverseProperty("SaleInvoiceTenderPo")]
    public virtual SaleInvoiceTender SaleInvoiceTender { get; set; } = null!;
}

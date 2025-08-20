using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SaleInvoiceTenderView
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Column("InvoiceID")]
    public Guid InvoiceId { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("TenderID")]
    public int TenderId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ReturnAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExchangeAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentDate { get; set; }

    [Column("CashierID")]
    public Guid? CashierId { get; set; }

    [StringLength(50)]
    public string? TenderName { get; set; }

    [StringLength(50)]
    public string? CashierName { get; set; }
}

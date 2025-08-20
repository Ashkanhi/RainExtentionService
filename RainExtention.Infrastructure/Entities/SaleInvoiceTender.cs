using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "LineItemId")]
[Table("SaleInvoiceTender")]
public partial class SaleInvoiceTender
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

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId")]
    [InverseProperty("SaleInvoiceTenders")]
    public virtual SaleInvoice SaleInvoice { get; set; } = null!;

    [InverseProperty("SaleInvoiceTender")]
    public virtual SaleInvoiceTenderCheque? SaleInvoiceTenderCheque { get; set; }

    [InverseProperty("SaleInvoiceTender")]
    public virtual SaleInvoiceTenderCredit? SaleInvoiceTenderCredit { get; set; }

    [InverseProperty("SaleInvoiceTender")]
    public virtual SaleInvoiceTenderGift? SaleInvoiceTenderGift { get; set; }

    [InverseProperty("SaleInvoiceTender")]
    public virtual SaleInvoiceTenderPo? SaleInvoiceTenderPo { get; set; }

    [ForeignKey("TenderId")]
    [InverseProperty("SaleInvoiceTenders")]
    public virtual Tender Tender { get; set; } = null!;
}

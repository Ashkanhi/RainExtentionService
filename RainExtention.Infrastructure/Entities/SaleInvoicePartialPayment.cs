using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "InvoiceId", "PaymentId")]
[Table("SaleInvoicePartialPayment")]
public partial class SaleInvoicePartialPayment
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
    [Column("PaymentID")]
    public int PaymentId { get; set; }

    [Column("PaymentTypeID")]
    public int? PaymentTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedWageAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedProfitAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PaymentAmount { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("SaleInvoicePartialPaymentPaymentTypes")]
    public virtual Dictionary? PaymentType { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId")]
    [InverseProperty("SaleInvoicePartialPayments")]
    public virtual SaleInvoice SaleInvoice { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("SaleInvoicePartialPaymentStatuses")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, InvoiceId, PaymentId")]
    [InverseProperty("SaleInvoicePartialPayments")]
    public virtual ICollection<TreasuryDocument> TreasuryDocuments { get; set; } = new List<TreasuryDocument>();
}

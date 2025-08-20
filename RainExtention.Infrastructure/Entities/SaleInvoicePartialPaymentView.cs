using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SaleInvoicePartialPaymentView
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Column("InvoiceID")]
    public Guid InvoiceId { get; set; }

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

    public int? DayToSettelment { get; set; }
}

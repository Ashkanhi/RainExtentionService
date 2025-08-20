using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SaleInvoiceView
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Column("InvoiceID")]
    public Guid InvoiceId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvoiceDate { get; set; }

    public DateOnly? BusinessDate { get; set; }

    [StringLength(50)]
    public string? InvoiceNumber { get; set; }

    [Column("InvoiceTypeID")]
    public int? InvoiceTypeId { get; set; }

    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedAmount { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? AuthorizeUser { get; set; }

    public bool? IsOnlineSale { get; set; }

    public int? ScanCount { get; set; }

    [Precision(3)]
    public TimeOnly? InvoiceTime { get; set; }

    [Column("SaleChannelID")]
    public int? SaleChannelId { get; set; }

    [Column("StockID")]
    public Guid? StockId { get; set; }

    public byte? SitNumber { get; set; }

    [StringLength(20)]
    public string? DailyInvoiceNumber { get; set; }

    [StringLength(100)]
    public string? CustomerName { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    [StringLength(50)]
    public string? BookerStoreName { get; set; }

    [StringLength(50)]
    public string? InvoiceType { get; set; }
}

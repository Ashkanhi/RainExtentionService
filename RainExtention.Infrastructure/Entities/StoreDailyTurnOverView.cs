using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class StoreDailyTurnOverView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    public DateOnly? BusinessDay { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalInvoiceCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalSaleQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalSaleAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalSaleTax { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalSaleDiscount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalReturnQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalReturnAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalRetunTax { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalReturnDiscount { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [StringLength(50)]
    public string? FinanceDocumentCode { get; set; }

    public bool? FinanceDocument { get; set; }

    [Column("ContractID")]
    public Guid? ContractId { get; set; }

    public int? TotalStockDocumentCount { get; set; }

    public int? TotalTreasuryDocumentCount { get; set; }

    public int? InvoiceCount { get; set; }

    public int? TreasuryCount { get; set; }

    public int? DocumentCount { get; set; }

    [StringLength(50)]
    public string? StoreName { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    public int HasDiff { get; set; }
}

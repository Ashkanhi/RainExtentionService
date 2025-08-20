using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("Currency")]
public partial class Currency
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value { get; set; }

    [StringLength(10)]
    public string? Symbol { get; set; }

    [StringLength(1)]
    public string? GroupingSymbol { get; set; }

    [StringLength(1)]
    public string? DecimalSymbol { get; set; }

    public byte? DecimalCount { get; set; }

    public bool? IsDefault { get; set; }

    [Column("ExternalID")]
    [StringLength(50)]
    public string? ExternalId { get; set; }

    [InverseProperty("Currency")]
    public virtual ICollection<CurrencyHistory> CurrencyHistories { get; set; } = new List<CurrencyHistory>();

    [InverseProperty("Currency")]
    public virtual ICollection<SalePrice> SalePrices { get; set; } = new List<SalePrice>();

    [InverseProperty("Currency")]
    public virtual ICollection<StockDocument> StockDocuments { get; set; } = new List<StockDocument>();

    [InverseProperty("Currency")]
    public virtual ICollection<SupplierContract> SupplierContracts { get; set; } = new List<SupplierContract>();

    [InverseProperty("Currency")]
    public virtual ICollection<Tender> Tenders { get; set; } = new List<Tender>();
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SupplierContractLineItemsView
{
    [Column("ContractID")]
    public Guid ContractId { get; set; }

    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MarginPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DamagePercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? LastCost { get; set; }

    [Column("ChangeTypeID")]
    public int? ChangeTypeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount4 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount5 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ManufacturerPrice { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    public bool Taxable { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TaxPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TollPercent { get; set; }

    [StringLength(50)]
    public string? UnitOfMeasure { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ContractId", "ItemId")]
public partial class SupplierContractLineItem
{
    [Key]
    [Column("ContractID")]
    public Guid ContractId { get; set; }

    [Key]
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

    [ForeignKey("ContractId")]
    [InverseProperty("SupplierContractLineItems")]
    public virtual SupplierContract Contract { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("SupplierContractLineItems")]
    public virtual Item Item { get; set; } = null!;
}

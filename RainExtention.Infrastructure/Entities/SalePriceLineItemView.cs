using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SalePriceLineItemView
{
    [Column("PriceID")]
    public Guid PriceId { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("ChangeTypeID")]
    public int? ChangeTypeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? LastPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ChangeAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PriceAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? LastCost { get; set; }

    public bool? IsActive { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ManufacturerPrice { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [StringLength(100)]
    public string DepartmentName { get; set; } = null!;

    [StringLength(100)]
    public string TaxGroupName { get; set; } = null!;

    [StringLength(50)]
    public string? UnitOfMeasure { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}

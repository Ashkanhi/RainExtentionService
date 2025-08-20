using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("CatalogId", "SizeId", "LineItemId")]
[Table("ProductCatalogSize")]
public partial class ProductCatalogSize
{
    [Key]
    [Column("CatalogID")]
    public Guid CatalogId { get; set; }

    [Key]
    [Column("SizeID")]
    public int SizeId { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Value { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Margin { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value4 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value5 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value6 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value7 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value8 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value9 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value10 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value11 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value12 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value13 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value14 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value15 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value16 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value17 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value18 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value19 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value20 { get; set; }

    [ForeignKey("CatalogId")]
    [InverseProperty("ProductCatalogSizes")]
    public virtual ProductCatalog Catalog { get; set; } = null!;

    [ForeignKey("SizeId, LineItemId")]
    [InverseProperty("ProductCatalogSizes")]
    public virtual ProductSizeItem ProductSizeItem { get; set; } = null!;
}

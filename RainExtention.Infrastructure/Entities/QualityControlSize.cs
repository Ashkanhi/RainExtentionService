using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ReferDocumentId", "ReferLineItemId", "SizeId", "LineItemId")]
[Table("QualityControlSize")]
public partial class QualityControlSize
{
    [Key]
    [Column("ReferDocumentID")]
    public Guid ReferDocumentId { get; set; }

    [Key]
    [Column("ReferLineItemID")]
    public Guid ReferLineItemId { get; set; }

    [Key]
    [Column("SizeID")]
    public int SizeId { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Value1 { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Value2 { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Value3 { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Value4 { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? Value5 { get; set; }

    public bool? Passed { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

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

    [Column("CatalogID")]
    public Guid? CatalogId { get; set; }

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

    [ForeignKey("SizeId, LineItemId")]
    [InverseProperty("QualityControlSizes")]
    public virtual ProductSizeItem ProductSizeItem { get; set; } = null!;

    [ForeignKey("ReferDocumentId, ReferLineItemId")]
    [InverseProperty("QualityControlSizes")]
    public virtual ProductionDocumentLineItem ProductionDocumentLineItem { get; set; } = null!;
}

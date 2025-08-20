using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("DocumentId", "LineItemId")]
[Table("ProductionDocumentLineItem")]
public partial class ProductionDocumentLineItem
{
    [Key]
    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

    [Key]
    [Column("LineItemID")]
    public Guid LineItemId { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("BomID")]
    public Guid? BomId { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Weight { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Cost { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Tax { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Toll { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Discount { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? StandardCost { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Length { get; set; }

    public bool? IsQualityControlChecked { get; set; }

    [Column("ReferDocumentID")]
    public Guid? ReferDocumentId { get; set; }

    [Column("ReferLineItemID")]
    public Guid? ReferLineItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? WageAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OverheadAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Wasted { get; set; }

    [Column("OrderItemID")]
    public Guid? OrderItemId { get; set; }

    [ForeignKey("BomId")]
    [InverseProperty("ProductionDocumentLineItems")]
    public virtual BillOfMaterial? Bom { get; set; }

    [ForeignKey("DocumentId")]
    [InverseProperty("ProductionDocumentLineItems")]
    public virtual ProductionDocument Document { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("ProductionDocumentLineItems")]
    public virtual Item? Item { get; set; }

    [InverseProperty("ProductionDocumentLineItem")]
    public virtual ICollection<QualityControlResult> QualityControlResults { get; set; } = new List<QualityControlResult>();

    [InverseProperty("ProductionDocumentLineItem")]
    public virtual ICollection<QualityControlSize> QualityControlSizes { get; set; } = new List<QualityControlSize>();
}

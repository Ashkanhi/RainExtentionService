using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ProductionDocumentLineItemView
{
    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

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

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? StandardWeight { get; set; }

    [StringLength(255)]
    public string? OrderItem { get; set; }
}

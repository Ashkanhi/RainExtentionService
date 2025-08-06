using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ProductionOrderLineItemView
{
    [Column("OrderID")]
    public Guid OrderId { get; set; }

    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column("PlanID")]
    public Guid? PlanId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? EstimatedCost { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? EstimatedPrice { get; set; }

    public int? EstimatedStartDay { get; set; }

    [Column("BomID")]
    public Guid? BomId { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [StringLength(101)]
    public string? SupplierName { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}

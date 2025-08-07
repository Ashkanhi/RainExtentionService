using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("OrderId", "ItemId")]
[Table("ProductionOrderLineItem")]
public partial class ProductionOrderLineItem
{
    [Key]
    [Column("OrderID")]
    public Guid OrderId { get; set; }

    [Key]
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

    [ForeignKey("ItemId")]
    [InverseProperty("ProductionOrderLineItems")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("OrderId")]
    [InverseProperty("ProductionOrderLineItems")]
    public virtual ProductionOrder Order { get; set; } = null!;

    [ForeignKey("PlanId")]
    [InverseProperty("ProductionOrderLineItems")]
    public virtual ProductionPlan? Plan { get; set; }

    [ForeignKey("SupplierId")]
    [InverseProperty("ProductionOrderLineItems")]
    public virtual Supplier? Supplier { get; set; }
}

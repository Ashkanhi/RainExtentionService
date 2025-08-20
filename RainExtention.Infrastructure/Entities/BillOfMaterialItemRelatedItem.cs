using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "ChildId", "ItemId")]
public partial class BillOfMaterialItemRelatedItem
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("ChildID")]
    public Guid ChildId { get; set; }

    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [ForeignKey("Id, ChildId")]
    [InverseProperty("BillOfMaterialItemRelatedItems")]
    public virtual BillOfMaterialItem BillOfMaterialItem { get; set; } = null!;

    [ForeignKey("ChildId")]
    [InverseProperty("BillOfMaterialItemRelatedItemChildren")]
    public virtual Item Child { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("BillOfMaterialItemRelatedItemItems")]
    public virtual Item Item { get; set; } = null!;
}

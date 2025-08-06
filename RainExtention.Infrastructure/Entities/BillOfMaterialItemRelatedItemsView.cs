using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class BillOfMaterialItemRelatedItemsView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("ChildID")]
    public Guid ChildId { get; set; }

    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }
}

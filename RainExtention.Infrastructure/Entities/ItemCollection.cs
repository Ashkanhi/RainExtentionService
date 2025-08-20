using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ItemId", "ChildItemId")]
[Table("ItemCollection")]
public partial class ItemCollection
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Key]
    [Column("ChildItemID")]
    public Guid ChildItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? UnitCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DefaultValue { get; set; }

    [ForeignKey("ChildItemId")]
    [InverseProperty("ItemCollectionChildItems")]
    public virtual Item ChildItem { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("ItemCollectionItems")]
    public virtual Item Item { get; set; } = null!;
}

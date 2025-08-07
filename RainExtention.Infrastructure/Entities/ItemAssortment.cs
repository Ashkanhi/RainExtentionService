using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ItemId", "AttributeId", "ValueId")]
[Table("ItemAssortment")]
public partial class ItemAssortment
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Key]
    [Column("AttributeID")]
    public Guid AttributeId { get; set; }

    [Key]
    [Column("ValueID")]
    public Guid ValueId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [ForeignKey("AttributeId, ValueId")]
    [InverseProperty("ItemAssortments")]
    public virtual AttributeValue AttributeValue { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("ItemAssortments")]
    public virtual Item Item { get; set; } = null!;
}

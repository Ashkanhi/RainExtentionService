using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ItemId", "AttributeId", "ValueId", "ChildId")]
[Table("ItemAttributeItem")]
public partial class ItemAttributeItem
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

    [Key]
    [Column("ChildID")]
    public Guid ChildId { get; set; }

    [ForeignKey("AttributeId, ValueId")]
    [InverseProperty("ItemAttributeItems")]
    public virtual AttributeValue AttributeValue { get; set; } = null!;

    [ForeignKey("ChildId")]
    [InverseProperty("ItemAttributeItems")]
    public virtual Item Child { get; set; } = null!;
}

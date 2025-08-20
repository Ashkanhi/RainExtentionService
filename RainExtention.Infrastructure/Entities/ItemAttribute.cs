using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ItemId", "AttributeId")]
[Table("ItemAttribute")]
public partial class ItemAttribute
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Key]
    [Column("AttributeID")]
    public Guid AttributeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemAttributes")]
    public virtual Item Item { get; set; } = null!;
}

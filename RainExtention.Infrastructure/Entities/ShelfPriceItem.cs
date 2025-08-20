using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("Id", "ItemId")]
[Table("ShelfPriceItem")]
public partial class ShelfPriceItem
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CurrentPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? UserPrice { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("ShelfPriceItems")]
    public virtual ShelfPrice IdNavigation { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("ShelfPriceItems")]
    public virtual Item Item { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("ItemId", "StockId", "SectionId")]
[Table("ItemStockSection")]
public partial class ItemStockSection
{
    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Key]
    [Column("StockID")]
    public Guid StockId { get; set; }

    [Key]
    [Column("SectionID")]
    public Guid SectionId { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemStockSections")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("SectionId")]
    [InverseProperty("ItemStockSections")]
    public virtual StockSection Section { get; set; } = null!;
}

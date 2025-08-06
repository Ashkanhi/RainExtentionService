using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("StockSection")]
public partial class StockSection
{
    [Column("StockID")]
    public Guid? StockId { get; set; }

    [Key]
    [Column("SectionID")]
    public Guid SectionId { get; set; }

    [Column("ParentID")]
    public Guid? ParentId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    public bool? AllowItem { get; set; }

    public string? Description { get; set; }

    [StringLength(20)]
    public string? Code { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<StockSection> InverseParent { get; set; } = new List<StockSection>();

    [InverseProperty("Section")]
    public virtual ICollection<ItemStockSection> ItemStockSections { get; set; } = new List<ItemStockSection>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual StockSection? Parent { get; set; }

    [ForeignKey("StockId")]
    [InverseProperty("StockSections")]
    public virtual Stock? Stock { get; set; }
}

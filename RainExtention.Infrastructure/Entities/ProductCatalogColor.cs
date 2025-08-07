using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("CatalogId", "ColorId")]
[Table("ProductCatalogColor")]
public partial class ProductCatalogColor
{
    [Key]
    [Column("CatalogID")]
    public Guid CatalogId { get; set; }

    [Key]
    [Column("ColorID")]
    public int ColorId { get; set; }

    [Column("AttributeID")]
    public Guid? AttributeId { get; set; }

    [Column("ValueID")]
    public Guid? ValueId { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }

    public byte[]? Value { get; set; }

    [ForeignKey("AttributeId, ValueId")]
    [InverseProperty("ProductCatalogColors")]
    public virtual AttributeValue? AttributeValue { get; set; }

    [ForeignKey("CatalogId")]
    [InverseProperty("ProductCatalogColors")]
    public virtual ProductCatalog Catalog { get; set; } = null!;
}

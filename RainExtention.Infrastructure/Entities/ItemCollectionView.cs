using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ItemCollectionView
{
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column("ChildItemID")]
    public Guid ChildItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? UnitCount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DefaultValue { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [Column("ItemTypeID")]
    public int? ItemTypeId { get; set; }

    [StringLength(50)]
    public string? UnitOfMeasure { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}

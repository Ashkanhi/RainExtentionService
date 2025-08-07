using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ItemStockSectionView
{
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column("StockID")]
    public Guid StockId { get; set; }

    [Column("SectionID")]
    public Guid SectionId { get; set; }

    [StringLength(50)]
    public string? SectionName { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }
}

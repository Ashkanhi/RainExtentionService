using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("TempItemCost")]
public partial class TempItemCost
{
    [StringLength(50)]
    public string? Barcode { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Cost { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MarginPercent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ManufacturerPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Price { get; set; }

    [Column("RowID")]
    public int? RowId { get; set; }
}

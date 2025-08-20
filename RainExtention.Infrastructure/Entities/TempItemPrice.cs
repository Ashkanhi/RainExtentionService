using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("TempItemPrice")]
public partial class TempItemPrice
{
    [StringLength(50)]
    public string? Barcode { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ChangeAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ManufacturerPrice { get; set; }

    [Column("RowID")]
    public int? RowId { get; set; }
}

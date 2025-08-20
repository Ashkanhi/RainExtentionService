using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("ImportCardex")]
public partial class ImportCardex
{
    [Column("StoreName ")]
    [StringLength(255)]
    public string? StoreName { get; set; }

    [Column("ItemName ")]
    [StringLength(255)]
    public string? ItemName { get; set; }

    [Column("ItemType ")]
    [StringLength(255)]
    public string? ItemType { get; set; }

    [Column("Barcode ")]
    [StringLength(255)]
    public string? Barcode { get; set; }

    [StringLength(255)]
    public string? UnitOfMeasure { get; set; }

    [Column("Brand ")]
    [StringLength(255)]
    public string? Brand { get; set; }

    [StringLength(255)]
    public string? PersianInvoiceDate { get; set; }

    [Column(TypeName = "decimal(38, 8)")]
    public decimal? QtyNew { get; set; }
}

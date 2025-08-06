using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class CurrencyView
{
    [Column("ID")]
    public int Id { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value { get; set; }

    [StringLength(10)]
    public string? Symbol { get; set; }

    [StringLength(1)]
    public string? GroupingSymbol { get; set; }

    [StringLength(1)]
    public string? DecimalSymbol { get; set; }

    public byte? DecimalCount { get; set; }

    public bool? IsDefault { get; set; }

    [Column("ExternalID")]
    [StringLength(50)]
    public string? ExternalId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    public int Language { get; set; }
}

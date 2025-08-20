using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class Sale
{
    [StringLength(50)]
    public string? Product { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Year2021 { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Year2022 { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Year2023 { get; set; }
}

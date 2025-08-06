using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class LastWeekTenderAmount
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? SaleAmount { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? ReturnAmount { get; set; }
}

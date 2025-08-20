using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class LastWeekDailySale
{
    [Column("DateID")]
    public int DateId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Date { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? ExpectedAmount { get; set; }
}

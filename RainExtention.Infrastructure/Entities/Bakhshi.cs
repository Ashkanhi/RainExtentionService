using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("Bakhshi")]
public partial class Bakhshi
{
    [StringLength(255)]
    public string? BarCode { get; set; }

    [Column("TaxID")]
    [StringLength(255)]
    public string? TaxId { get; set; }
}

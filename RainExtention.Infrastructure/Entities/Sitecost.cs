using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("SITECOST")]
public partial class Sitecost
{
    public double? Barcode { get; set; }

    public double? Cost { get; set; }
}

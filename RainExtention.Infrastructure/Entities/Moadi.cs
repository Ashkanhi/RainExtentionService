using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("moadi")]
public partial class Moadi
{
    public double? Barcode { get; set; }

    [Column("CommodityID")]
    public double? CommodityId { get; set; }
}

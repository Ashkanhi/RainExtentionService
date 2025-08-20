using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SalePriceStoreAssignmentView
{
    [Column("PriceID")]
    public Guid PriceId { get; set; }

    [Column("StoreID")]
    public int StoreId { get; set; }

    [StringLength(50)]
    public string? StoreName { get; set; }
}

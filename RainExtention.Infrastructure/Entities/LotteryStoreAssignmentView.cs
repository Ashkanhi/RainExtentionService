using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class LotteryStoreAssignmentView
{
    [Column("LotteryID")]
    public Guid LotteryId { get; set; }

    [Column("StoreID")]
    public int StoreId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }
}

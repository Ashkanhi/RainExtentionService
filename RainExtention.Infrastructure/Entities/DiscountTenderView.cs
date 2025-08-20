using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class DiscountTenderView
{
    [Column("DiscountID")]
    public Guid DiscountId { get; set; }

    [Column("TenderID")]
    public int TenderId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }
}

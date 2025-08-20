using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("PriceId", "TypeId", "Value")]
[Table("SalePriceActiveTime")]
public partial class SalePriceActiveTime
{
    [Key]
    [Column("PriceID")]
    public Guid PriceId { get; set; }

    [Key]
    [Column("TypeID")]
    public int TypeId { get; set; }

    [Key]
    public int Value { get; set; }

    [ForeignKey("PriceId")]
    [InverseProperty("SalePriceActiveTimes")]
    public virtual SalePrice Price { get; set; } = null!;
}

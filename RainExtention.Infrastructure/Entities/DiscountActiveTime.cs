using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("DiscountId", "TypeId", "Value")]
[Table("DiscountActiveTime")]
public partial class DiscountActiveTime
{
    [Key]
    [Column("DiscountID")]
    public Guid DiscountId { get; set; }

    [Key]
    [Column("TypeID")]
    public int TypeId { get; set; }

    [Key]
    public int Value { get; set; }

    [ForeignKey("DiscountId")]
    [InverseProperty("DiscountActiveTimes")]
    public virtual Discount Discount { get; set; } = null!;
}

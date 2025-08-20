using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("DiscountId", "LevelId")]
[Table("DiscountPriceLevel")]
public partial class DiscountPriceLevel
{
    [Key]
    [Column("DiscountID")]
    public Guid DiscountId { get; set; }

    [Key]
    [Column("LevelID")]
    public int LevelId { get; set; }

    [Column("DiscountTypeID")]
    public int? DiscountTypeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [ForeignKey("DiscountTypeId")]
    [InverseProperty("DiscountPriceLevels")]
    public virtual Dictionary? DiscountType { get; set; }
}

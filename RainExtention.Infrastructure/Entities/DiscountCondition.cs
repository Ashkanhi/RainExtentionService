using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("DiscountId", "ConditionId")]
[Table("DiscountCondition")]
public partial class DiscountCondition
{
    [Key]
    [Column("DiscountID")]
    public Guid DiscountId { get; set; }

    [Key]
    [Column("ConditionID")]
    public int ConditionId { get; set; }

    [Column("ConditionTypeID")]
    public int? ConditionTypeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConditionValueFrom { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConditionValueTo { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountValue { get; set; }

    [ForeignKey("DiscountId")]
    [InverseProperty("DiscountConditions")]
    public virtual Discount Discount { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("PriceId", "LineItemId")]
[Table("SalePriceConditional")]
public partial class SalePriceConditional
{
    [Key]
    [Column("PriceID")]
    public Guid PriceId { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [StringLength(50)]
    public string? Condition { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PriceAmount { get; set; }

    [ForeignKey("PriceId")]
    [InverseProperty("SalePriceConditionals")]
    public virtual SalePrice Price { get; set; } = null!;
}

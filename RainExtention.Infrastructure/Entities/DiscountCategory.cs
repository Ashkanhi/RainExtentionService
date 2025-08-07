using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("DiscountCategory")]
public partial class DiscountCategory
{
    [Key]
    [Column("DiscountCategoryID")]
    public int DiscountCategoryId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [InverseProperty("DiscountCategory")]
    public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();
}

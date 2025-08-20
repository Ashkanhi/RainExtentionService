using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("DiscountId", "TenderId")]
[Table("DiscountTender")]
public partial class DiscountTender
{
    [Key]
    [Column("DiscountID")]
    public Guid DiscountId { get; set; }

    [Key]
    [Column("TenderID")]
    public int TenderId { get; set; }

    [ForeignKey("DiscountId")]
    [InverseProperty("DiscountTenders")]
    public virtual Discount Discount { get; set; } = null!;
}

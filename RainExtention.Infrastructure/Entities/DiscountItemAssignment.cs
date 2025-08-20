using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("DiscountId", "ItemId")]
[Table("DiscountItemAssignment")]
public partial class DiscountItemAssignment
{
    [Key]
    [Column("DiscountID")]
    public Guid DiscountId { get; set; }

    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SupplierDiscount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxQuantity { get; set; }

    [ForeignKey("DiscountId")]
    [InverseProperty("DiscountItemAssignments")]
    public virtual Discount DiscountNavigation { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("DiscountItemAssignments")]
    public virtual Item Item { get; set; } = null!;
}

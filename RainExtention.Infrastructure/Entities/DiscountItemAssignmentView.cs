using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class DiscountItemAssignmentView
{
    [Column("DiscountID")]
    public Guid DiscountId { get; set; }

    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SupplierDiscount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MaxQuantity { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CurrentPrice { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("PriceId", "LineItemId")]
[Table("SalePriceLineItem")]
public partial class SalePriceLineItem
{
    [Key]
    [Column("PriceID")]
    public Guid PriceId { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("ChangeTypeID")]
    public int? ChangeTypeId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? LastPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ChangeAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PriceAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? LastCost { get; set; }

    public bool? IsActive { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ManufacturerPrice { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [ForeignKey("ChangeTypeId")]
    [InverseProperty("SalePriceLineItems")]
    public virtual Dictionary? ChangeType { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("SalePriceLineItems")]
    public virtual Item? Item { get; set; }

    [ForeignKey("PriceId")]
    [InverseProperty("SalePriceLineItems")]
    public virtual SalePrice Price { get; set; } = null!;
}

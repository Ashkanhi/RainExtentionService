using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ItemSalePriceView
{
    [Column("PriceID")]
    public Guid PriceId { get; set; }

    [Column("LineItemID")]
    public int? LineItemId { get; set; }

    [Column("PriceTypeID")]
    public int? PriceTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [Column("CustomerGroupID")]
    public Guid? CustomerGroupId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PriceAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ManufacturerPrice { get; set; }

    [Column(TypeName = "decimal(37, 6)")]
    public decimal? LastCost { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    public int? ActiveDay { get; set; }

    public int? ActiveHour { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    [Column("GroupID")]
    public Guid? GroupId { get; set; }

    public bool? IsActive { get; set; }

    [Column("ReasonID")]
    public int? ReasonId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }
}

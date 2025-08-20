using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class CurrentItemPriceView
{
    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("CustomerGroupID")]
    public Guid? CustomerGroupId { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    [Column("ReasonID")]
    public int? ReasonId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PriceAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerPrice { get; set; }

    [Column(TypeName = "decimal(37, 6)")]
    public decimal? LastCost { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class CustomerItemFavoritesView
{
    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    public byte[]? ItemImage { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CurrentPrice { get; set; }
}

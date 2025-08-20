using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class SupplierItemView
{
    [Column("SupplierID")]
    public Guid SupplierId { get; set; }

    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column("StatusID")]
    public bool? StatusId { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }
}

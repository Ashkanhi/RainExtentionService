using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("SupplierId", "ItemId")]
[Table("SupplierItem")]
public partial class SupplierItem
{
    [Key]
    [Column("SupplierID")]
    public Guid SupplierId { get; set; }

    [Key]
    [Column("ItemID")]
    public Guid ItemId { get; set; }

    [Column("StatusID")]
    public bool? StatusId { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("SupplierItems")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("SupplierId")]
    [InverseProperty("SupplierItems")]
    public virtual Supplier Supplier { get; set; } = null!;
}

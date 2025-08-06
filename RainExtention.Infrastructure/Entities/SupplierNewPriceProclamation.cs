using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("SupplierNewPriceProclamation")]
public partial class SupplierNewPriceProclamation
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Cost { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("SupplierNewPriceProclamations")]
    public virtual Item? Item { get; set; }

    [ForeignKey("SupplierId")]
    [InverseProperty("SupplierNewPriceProclamations")]
    public virtual Supplier? Supplier { get; set; }
}

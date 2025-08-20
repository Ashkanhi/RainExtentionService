using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("SupplierNewItemProclamation")]
public partial class SupplierNewItemProclamation
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [StringLength(100)]
    public string? ItemName { get; set; }

    [StringLength(50)]
    public string? Barcode { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsumerPrice { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Cost { get; set; }

    public int? Status { get; set; }

    [ForeignKey("SupplierId")]
    [InverseProperty("SupplierNewItemProclamations")]
    public virtual Supplier? Supplier { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("SupplierCustomField")]
public partial class SupplierCustomField
{
    [Key]
    [Column("SupplierID")]
    public Guid SupplierId { get; set; }

    [StringLength(100)]
    public string? SupplierGroup { get; set; }

    [ForeignKey("SupplierId")]
    [InverseProperty("SupplierCustomField")]
    public virtual Supplier Supplier { get; set; } = null!;
}

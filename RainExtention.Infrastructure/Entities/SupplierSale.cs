using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("SupplierSale")]
public partial class SupplierSale
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string? DocumentCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual ICollection<SupplierSaleLineItem> SupplierSaleLineItems { get; set; } = new List<SupplierSaleLineItem>();

    [ForeignKey("Id")]
    [InverseProperty("Ids")]
    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}

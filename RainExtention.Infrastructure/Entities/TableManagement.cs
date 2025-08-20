using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("TableManagement")]
public partial class TableManagement
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    public byte? TableNo { get; set; }

    public byte? Capacity { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [InverseProperty("Table")]
    public virtual ICollection<SaleInvoiceInfo> SaleInvoiceInfos { get; set; } = new List<SaleInvoiceInfo>();

    [ForeignKey("StatusId")]
    [InverseProperty("TableManagements")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("TableManagements")]
    public virtual Store? Store { get; set; }

    [InverseProperty("Table")]
    public virtual ICollection<SuspendInvoice> SuspendInvoices { get; set; } = new List<SuspendInvoice>();
}

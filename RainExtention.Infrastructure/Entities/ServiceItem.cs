using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ServiceItem")]
public partial class ServiceItem
{
    [Key]
    public Guid ServiceId { get; set; }

    [StringLength(50)]
    public string? ServiceName { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? BasePrice { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("ServiceItems")]
    public virtual Department? Department { get; set; }

    [InverseProperty("Service")]
    public virtual ICollection<SaleInvoiceService> SaleInvoiceServices { get; set; } = new List<SaleInvoiceService>();
}

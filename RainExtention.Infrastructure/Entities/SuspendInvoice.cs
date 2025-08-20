using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("SuspendInvoice")]
public partial class SuspendInvoice
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string? SuspendNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SuspendDate { get; set; }

    public string? Invoice { get; set; }

    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [Column("TableID")]
    public Guid? TableId { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("SuspendInvoices")]
    public virtual Customer? Customer { get; set; }

    [ForeignKey("TableId")]
    [InverseProperty("SuspendInvoices")]
    public virtual TableManagement? Table { get; set; }
}

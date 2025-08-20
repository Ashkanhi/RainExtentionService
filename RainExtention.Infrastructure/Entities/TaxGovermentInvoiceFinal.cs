using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("TaxGovermentInvoiceFinal")]
public partial class TaxGovermentInvoiceFinal
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string InvoiceId { get; set; } = null!;

    [StringLength(4000)]
    public string? LastStatus { get; set; }

    public int? Done { get; set; }

    [StringLength(50)]
    public string? TaxId { get; set; }

    [StringLength(50)]
    public string? LastRefrenceId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastResponseCheckTime { get; set; }
}

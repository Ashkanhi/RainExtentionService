using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("TaxGovermentInvoiceInfo")]
public partial class TaxGovermentInvoiceInfo
{
    [Key]
    public long TaxGovermentInvoiceInfoId { get; set; }

    public Guid InvoiceId { get; set; }

    [StringLength(100)]
    public string? ReferenceNumber { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [StringLength(50)]
    public string? InvoiceUniqueId { get; set; }

    [Column("UId")]
    [StringLength(100)]
    public string? Uid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SendDate { get; set; }

    public bool? IsReturn { get; set; }

    public bool? Done { get; set; }
}

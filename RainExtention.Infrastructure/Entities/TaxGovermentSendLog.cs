using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("TaxGovermentSendLog")]
public partial class TaxGovermentSendLog
{
    [Key]
    public long LogId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [StringLength(100)]
    public string? RefrenceId { get; set; }

    [Column("UId")]
    [StringLength(100)]
    public string? Uid { get; set; }

    public string? Json { get; set; }

    [StringLength(10)]
    public string? TaxGovermentInvoiceInfoId { get; set; }

    [StringLength(50)]
    public string? PacketType { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("TaxHistory")]
public partial class TaxHistory
{
    public int SendStat { get; set; }

    [StringLength(100)]
    public string? InvoiceId { get; set; }

    [StringLength(50)]
    public string? StorName { get; set; }

    [StringLength(152)]
    public string? CustomerName { get; set; }

    [StringLength(50)]
    public string? InvoiceNumberSt { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? TotalPrice { get; set; }

    [Column(TypeName = "decimal(38, 0)")]
    public decimal? TotalDiscount { get; set; }

    [Column(TypeName = "decimal(38, 0)")]
    public decimal? TotalTax { get; set; }

    [Column(TypeName = "decimal(38, 0)")]
    public decimal? NetPrice { get; set; }

    public DateOnly? BusinessDate { get; set; }

    [StringLength(100)]
    public string? ReferenceNumber { get; set; }
}

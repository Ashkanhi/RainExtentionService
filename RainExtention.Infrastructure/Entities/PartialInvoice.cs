using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class PartialInvoice
{
    [StringLength(50)]
    public string? InvoiceNumber { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InvoiceDate { get; set; }

    [StringLength(100)]
    public string? CustomerName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SettelmentDate { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? DeliveryPrice { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? RemainAmount { get; set; }

    [StringLength(50)]
    public string? InvoiceType { get; set; }
}

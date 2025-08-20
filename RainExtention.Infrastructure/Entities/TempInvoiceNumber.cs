using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("TempInvoiceNumber")]
public partial class TempInvoiceNumber
{
    [StringLength(50)]
    public string? InvoiceNumber { get; set; }
}

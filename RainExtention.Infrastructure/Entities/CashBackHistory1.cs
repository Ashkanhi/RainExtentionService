using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("CashBack_History_1")]
public partial class CashBackHistory1
{
    [Column("InvoiceID")]
    public Guid InvoiceId { get; set; }

    [Column("point", TypeName = "decimal(10, 3)")]
    public decimal? Point { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Credit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Darsad { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? FirstPurchase { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpectedAmount { get; set; }
}

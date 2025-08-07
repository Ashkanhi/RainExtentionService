using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
[Table("customerduplicate")]
public partial class Customerduplicate
{
    [Column("first_value")]
    public Guid? FirstValue { get; set; }

    public long? Rowid { get; set; }

    [Column("CustomerID")]
    public Guid CustomerId { get; set; }

    [StringLength(50)]
    public string? CustomerCode { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? AcceptPoint { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? ModifyCredit { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? RemainCredit { get; set; }

    [Column("cnt")]
    public int? Cnt { get; set; }
}

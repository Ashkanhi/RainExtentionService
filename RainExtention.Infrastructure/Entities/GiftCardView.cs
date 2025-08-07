using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class GiftCardView
{
    [Column("ID")]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    [Column("TypeID")]
    public int? TypeId { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Thershold { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationTime { get; set; }

    public Guid? CreationUser { get; set; }

    public int? SolledCount { get; set; }

    public int? PaidCount { get; set; }

    public int? VoidCount { get; set; }
}
